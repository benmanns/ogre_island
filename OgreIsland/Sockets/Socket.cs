using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Xml;

using OgreIsland.Packets;
using OgreIsland.Sockets.Events;

namespace OgreIsland.Sockets
{
    public class Socket
    {
        private const int BufferSize = 1024;
        private readonly Protocol _sendProtocol;
        private readonly Protocol _receiveProtocol;
        private readonly List<byte> _sendBuffer = new List<byte>();
        private readonly List<byte> _receiveBuffer = new List<byte>(BufferSize);
        private readonly System.Net.Sockets.Socket _socket = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public event ConnectedEventHandler Connected;
        public event DisconnectedEventHandler Disconnected;
        public event ReceivedEventHandler Received;
        public event SentEventHandler Sent;

        public event AbstractPacketReceivedEventHandler AbstractPacketReceived;
        public event ActionPacketReceivedEventHandler ActionPacketReceived;
        public event AddCharacterPacketReceivedEventHandler AddCharacterPacketReceived;
        public event AddObjectPacketReceivedEventHandler AddObjectPacketReceived;
        public event AddPlayerPacketReceivedEventHandler AddPlayerPacketReceived;
        public event AddToBagPacketReceivedEventHandler AddToBagPacketReceived;
        public event AdminPacketReceivedEventHandler AdminPacketReceived;

        public Socket(Protocol send, Protocol receive)
        {
            _sendProtocol = send;
            _receiveProtocol = receive;
            Connected += SocketConnected;
        }

        public void Send(string command, string[] arguments) { Send(new Packet(command, arguments)); }
        public void Send(Packet packet) { Send(new PacketList(packet)); }
        public void Send(AbstractPacket packet) { Send(new PacketList(packet)); }
        public void Send(PacketList packetList)
        {
            switch (_sendProtocol)
            {
                case Protocol.Delimited:
                    {
                        MemoryStream stream = new MemoryStream();
                        BinaryWriter writer = new BinaryWriter(stream);
                        foreach (AbstractPacket packet in packetList)
                        {
                            writer.Write(packet.Command.ToCharArray());
                            if (packet.Arguments != null)
                            {
                                writer.Write((char)1);
                                writer.Write(string.Join(new string(new[] { (char)0 }), packet.Arguments).ToCharArray());
                            }
                            writer.Write((char)0);
                        }
                        writer.Close();
                        Send(stream.ToArray(), new State(_socket, packetList));
                        break;
                    }
                case Protocol.Xml:
                    {
                        MemoryStream stream = new MemoryStream();
                        XmlWriterSettings settings = new XmlWriterSettings
                        {
                            OmitXmlDeclaration = true,
                            NewLineHandling = NewLineHandling.None
                        };
                        XmlWriter writer = XmlWriter.Create(stream, settings);
                        writer.WriteStartElement("p");
                        {
                            writer.WriteAttributeString("c", packetList.Count.ToString());
                            foreach (AbstractPacket packet in packetList)
                            {
                                writer.WriteStartElement("m");
                                {
                                    writer.WriteAttributeString("p", packet.Arguments.Length.ToString());
                                    writer.WriteAttributeString("p0", packet.Command);
                                    for (int index = 0; index < packet.Arguments.Length; index++) writer.WriteAttributeString(string.Format("p{0}", index + 1), packet.Arguments[index]);
                                }
                                writer.WriteEndElement();
                            }
                        }
                        writer.WriteEndElement();
                        writer.Close();
                        Send(stream.ToArray(), new State(_socket, packetList));
                        break;
                    }
                default: throw new ArgumentOutOfRangeException();
            }
        }
        public void Send(byte[] data) { Send(data, new State(_socket)); }
        public void Send(byte[] data, State state)
        {
            if (!_socket.Connected) _sendBuffer.AddRange(data);
            else
            {
                SocketError error;
                _socket.BeginSend(data, 0, data.Length, SocketFlags.None, out error, SentCallback, state);
                if (error != SocketError.Success)
                {
                    Console.Error.WriteLine("Socket Error: {0}", error);
                    Disconnect();
                }
            }
        }

        public void Disconnect() { _socket.BeginDisconnect(false, DisonnectedCallback, new State(_socket)); }

        public void Connect(string host, int port) { _socket.BeginConnect(host, port, ConnectedCallback, new State(_socket)); }

        private void ConnectedCallback(IAsyncResult asyncResult)
        {
            State state = (State)asyncResult.AsyncState;
            if (state.Socket != null)
            {
                state.Socket.EndConnect(asyncResult);
                OnConnected();
            }
            else throw new NullReferenceException();
        }

        private void DisonnectedCallback(IAsyncResult asyncResult)
        {
            State state = (State)asyncResult.AsyncState;
            if (state.Socket != null)
            {
                state.Socket.EndDisconnect(asyncResult);
                OnDisconnected();
            }
            else throw new NullReferenceException();
        }

        private void ReceivedCallback(IAsyncResult asyncResult)
        {
            State state = (State)asyncResult.AsyncState;
            if (state.Socket != null)
            {
                SocketError error;
                int length = state.Socket.EndReceive(asyncResult, out error);
                if (error != SocketError.Success)
                {
                    Console.Error.WriteLine("Socket Error: {0}", error);
                    Disconnect();
                }
                else
                {
                    for (int index = 0; index < length; index++)
                    {
                        if (state.Buffer[index] == 0)
                        {
                            PacketList packetList = PacketFactory.Create(_receiveProtocol, _receiveBuffer);
                            foreach (AbstractPacket packet in packetList) OnReceived(packet);
                            _receiveBuffer.Clear();
                        }
                        else _receiveBuffer.Add(state.Buffer[index]);
                        if (state.Buffer[index] == (byte)'&')
                        {
                            _receiveBuffer.AddRange(new[] { (byte)'a', (byte)'m', (byte)'p', (byte)';' });
                        }
                    }
                }
                state.Socket.BeginReceive(state.Buffer, 0, state.Buffer.Length, SocketFlags.None, out error, ReceivedCallback, state);
                if (error != SocketError.Success)
                {
                    Console.Error.WriteLine("Socket Error: {0}", error);
                    Disconnect();
                }
            }
            else throw new NullReferenceException();
        }

        private void SentCallback(IAsyncResult asyncResult)
        {
            State state = (State)asyncResult.AsyncState;
            if (state.Socket != null)
            {
                SocketError error;
                state.Socket.EndReceive(asyncResult, out error);
                if (error != SocketError.Success)
                {
                    Console.Error.WriteLine("Socket Error: {0}", error);
                    Disconnect();
                }
                else if (state.PacketList != null) foreach (AbstractPacket packet in state.PacketList) OnSent(PacketFactory.Cast(packet));
            }
            else throw new NullReferenceException();
        }

        private void OnConnected() { OnConnected(new ConnectedEventArgs()); }
        private void OnConnected(ConnectedEventArgs e) { if (Connected != null) Connected(this, e); }

        private void OnDisconnected() { OnDisconnected(new DisconnectedEventArgs()); }
        private void OnDisconnected(DisconnectedEventArgs e) { if (Disconnected != null) Disconnected(this, e); }

        private void OnReceived(AbstractPacket packet) { OnReceived(new ReceivedEventArgs(packet)); }
        private void OnReceived(ReceivedEventArgs e)
        {
            if (Received != null) Received(this, e);
            switch (e.Packet.Command)
            {
                case "ACTION": OnActionPacketReceived((ActionPacket)e.Packet); break;
                case "ADDCHAR": OnAddCharacterPacketReceived((AddCharacterPacket)e.Packet); break;
                case "ADDOBJ": OnAddObjectPacketReceived((AddObjectPacket)e.Packet); break;
                case "ADDPLAYER": OnAddPlayerPacketReceived((AddPlayerPacket)e.Packet); break;
                case "ADDTOBAG": OnAddToBagPacketReceived((AddToBagPacket)e.Packet); break;
                case "ADMIN": OnAdminPacketReceived((AdminPacket)e.Packet); break;
                default: OnAbstractPacketReceived(e.Packet); break;
            }
        }

        private void OnSent(AbstractPacket packet) { OnSent(new SentEventArgs(packet)); }
        private void OnSent(SentEventArgs e) { if (Sent != null) Sent(this, e); }

        private void OnAbstractPacketReceived(AbstractPacket packet) { OnAbstractPacketReceived(new AbstractPacketReceivedEventArgs(packet)); }
        private void OnAbstractPacketReceived(AbstractPacketReceivedEventArgs e)
        {
            if (AbstractPacketReceived != null) AbstractPacketReceived(this, e);
        }
        private void OnActionPacketReceived(ActionPacket packet) { OnActionPacketReceived(new ActionPacketReceivedEventArgs(packet)); }
        private void OnActionPacketReceived(ActionPacketReceivedEventArgs e)
        {
            if (ActionPacketReceived != null) ActionPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnAddCharacterPacketReceived(AddCharacterPacket packet) { OnAddCharacterPacketReceived(new AddCharacterPacketReceivedEventArgs(packet)); }
        private void OnAddCharacterPacketReceived(AddCharacterPacketReceivedEventArgs e)
        {
            if (AddCharacterPacketReceived != null) AddCharacterPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnAddObjectPacketReceived(AddObjectPacket packet) { OnAddObjectPacketReceived(new AddObjectPacketReceivedEventArgs(packet)); }
        private void OnAddObjectPacketReceived(AddObjectPacketReceivedEventArgs e)
        {
            if (AddObjectPacketReceived != null) AddObjectPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnAddPlayerPacketReceived(AddPlayerPacket packet) { OnAddPlayerPacketReceived(new AddPlayerPacketReceivedEventArgs(packet)); }
        private void OnAddPlayerPacketReceived(AddPlayerPacketReceivedEventArgs e)
        {
            if (AddPlayerPacketReceived != null) AddPlayerPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnAddToBagPacketReceived(AddToBagPacket packet) { OnAddToBagPacketReceived(new AddToBagPacketReceivedEventArgs(packet)); }
        private void OnAddToBagPacketReceived(AddToBagPacketReceivedEventArgs e)
        {
            if (AddToBagPacketReceived != null) AddToBagPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnAdminPacketReceived(AdminPacket packet) { OnAdminPacketReceived(new AdminPacketReceivedEventArgs(packet)); }
        private void OnAdminPacketReceived(AdminPacketReceivedEventArgs e)
        {
            if (AdminPacketReceived != null) AdminPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void SocketConnected(object sender, ConnectedEventArgs e)
        {
            if (_sendBuffer.Count > 0)
            {
                Send(_sendBuffer.ToArray());
                _sendBuffer.Clear();
            }
            byte[] buffer = new byte[BufferSize];
            _socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceivedCallback), new State(_socket, buffer));
        }
    }
}
