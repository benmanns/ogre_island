﻿using System;
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
        public event AttackPacketReceivedEventHandler AttackPacketReceived;
        public event AttributePacketReceivedEventHandler AttributePacketReceived;
        public event BackgroundColorPacketReceivedEventHandler BackgroundColorPacketReceived;
        public event BattleTextMiscellaneousPacketReceivedEventHandler BattleTextMiscellaneousPacketReceived;
        public event ChatChannelPacketReceivedEventHandler ChatChannelPacketReceived;
        public event CharacterAttributePacketReceivedEventHandler CharacterAttributePacketReceived;
        public event ClearSpellPacketReceivedEventHandler ClearSpellPacketReceived;
        public event CloseLootPacketReceivedEventHandler CloseLootPacketReceived;
        public event CloseWindowPacketReceivedEventHandler CloseWindowPacketReceived;
        public event ConfigurationPacketReceivedEventHandler ConfigurationPacketReceived;
        public event DebugPacketReceivedEventHandler DebugPacketReceived;
        public event EditModePacketReceivedEventHandler EditModePacketReceived;
        public event EditObjectPacketReceivedEventHandler EditObjectPacketReceived;
        public event FocusPacketReceivedEventHandler FocusPacketReceived;
        public event GuildMiscellaneousPacketReceivedEventHandler GuildMiscellaneousPacketReceived;
        public event GoodbyePacketReceivedEventHandler GoodbyePacketReceived;
        public event GetVariablePacketReceivedEventHandler GetVariablePacketReceived;
        public event HandshakePacketReceivedEventHandler HandshakePacketReceived;
        public event HealthBarPacketReceivedEventHandler HealthBarPacketReceived;
        public event HideObjectPacketReceivedEventHandler HideObjectPacketReceived;
        public event HouseItemTabPacketReceivedEventHandler HouseItemTabPacketReceived;
        public event InitializationBarPacketReceivedEventHandler InitializationBarPacketReceived;
        public event InventoryPacketReceivedEventHandler InventoryPacketReceived;
        public event JoinPacketReceivedEventHandler JoinPacketReceived;
        public event LeavePacketReceivedEventHandler LeavePacketReceived;
        public event LoadPanelPacketReceivedEventHandler LoadPanelPacketReceived;
        public event LoadPicturePacketReceivedEventHandler LoadPicturePacketReceived;
        public event LockPacketReceivedEventHandler LockPacketReceived;
        public event LoginReplyPacketReceivedEventHandler LoginReplyPacketReceived;
        public event MeAttributePacketReceivedEventHandler MeAttributePacketReceived;
        public event MiscellaneousPacketReceivedEventHandler MiscellaneousPacketReceived;
        public event ModifyBagItemPacketReceivedEventHandler ModifyBagItemPacketReceived;
        public event ModifyObjectPacketReceivedEventHandler ModifyObjectPacketReceived;
        public event MovePacketReceivedEventHandler MovePacketReceived;
        public event MoveObjectPacketReceivedEventHandler MoveObjectPacketReceived;
        public event MoveObjectOtherPacketReceivedEventHandler MoveObjectOtherPacketReceived;
        public event MessageBoxPacketReceivedEventHandler MessageBoxPacketReceived;
        public event NewLockBoxPacketReceivedEventHandler NewLockBoxPacketReceived;
        public event NoFloodWarningPacketReceivedEventHandler NoFloodWarningPacketReceived;
        public event OpenPanelPacketReceivedEventHandler OpenPanelPacketReceived;
        public event OpenUrlPacketReceivedEventHandler OpenUrlPacketReceived;
        public event OpenWindowPacketReceivedEventHandler OpenWindowPacketReceived;
        public event PartyPacketReceivedEventHandler PartyPacketReceived;
        public event PlayPacketReceivedEventHandler PlayPacketReceived;
        public event PlayerMenuPacketReceivedEventHandler PlayerMenuPacketReceived;
        public event RemoveCharacterPacketReceivedEventHandler RemoveCharacterPacketReceived;
        public event RemoveObjectPacketReceivedEventHandler RemoveObjectPacketReceived;
        public event RemovePlayerPacketReceivedEventHandler RemovePlayerPacketReceived;
        public event SayPacketReceivedEventHandler SayPacketReceived;
        public event SpellBarTextLeftPacketReceivedEventHandler SpellBarTextLeftPacketReceived;
        public event SpellBarTextRightPacketReceivedEventHandler SpellBarTextRightPacketReceived;
        public event SelectedPacketReceivedEventHandler SelectedPacketReceived;
        public event SetActionPacketReceivedEventHandler SetActionPacketReceived;
        public event SetClipsPacketReceivedEventHandler SetClipsPacketReceived;
        public event SetSkillPacketReceivedEventHandler SetSkillPacketReceived;
        public event SetSkillBarPacketReceivedEventHandler SetSkillBarPacketReceived;
        public event SetSpellBarPacketReceivedEventHandler SetSpellBarPacketReceived;
        public event SetTextPacketReceivedEventHandler SetTextPacketReceived;
        public event ShowHouseLockPacketReceivedEventHandler ShowHouseLockPacketReceived;
        public event ShowObjectPacketReceivedEventHandler ShowObjectPacketReceived;
        public event SkinningPacketReceivedEventHandler SkinningPacketReceived;
        public event SoundPacketReceivedEventHandler SoundPacketReceived;
        public event SoundTogglePacketReceivedEventHandler SoundTogglePacketReceived;
        public event SpecBarPacketReceivedEventHandler SpecBarPacketReceived;
        public event SpellPacketReceivedEventHandler SpellPacketReceived;
        public event StatisticPacketReceivedEventHandler StatisticPacketReceived;
        public event StatusPacketReceivedEventHandler StatusPacketReceived;
        public event StopPacketReceivedEventHandler StopPacketReceived;
        public event SetVariablePacketReceivedEventHandler SetVariablePacketReceived;
        public event TakeFromBagPacketReceivedEventHandler TakeFromBagPacketReceived;
        public event TickPacketReceivedEventHandler TickPacketReceived;
        public event ToolIconPacketReceivedEventHandler ToolIconPacketReceived;
        public event TradeWindowPacketReceivedEventHandler TradeWindowPacketReceived;
        public event WarpPacketReceivedEventHandler WarpPacketReceived;
        public event WeatherPacketReceivedEventHandler WeatherPacketReceived;
        public event WLevelPacketReceivedEventHandler WLevelPacketReceived;

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
                case "ATTACK": OnAttackPacketReceived((AttackPacket)e.Packet); break;
                case "ATTRIB": OnAttributePacketReceived((AttributePacket)e.Packet); break;
                case "BGCOLOR": OnBackgroundColorPacketReceived((BackgroundColorPacket)e.Packet); break;
                case "BTMISC": OnBattleTextMiscellaneousPacketReceived((BattleTextMiscellaneousPacket)e.Packet); break;
                case "CCHANNEL": OnChatChannelPacketReceived((ChatChannelPacket)e.Packet); break;
                case "CHARATTRIB": OnCharacterAttributePacketReceived((CharacterAttributePacket)e.Packet); break;
                case "CLEARSPELL": OnClearSpellPacketReceived((ClearSpellPacket)e.Packet); break;
                case "CLOSELOOT": OnCloseLootPacketReceived((CloseLootPacket)e.Packet); break;
                case "CLOSEWINDOW": OnCloseWindowPacketReceived((CloseWindowPacket)e.Packet); break;
                case "CONFIG": OnConfigurationPacketReceived((ConfigurationPacket)e.Packet); break;
                case "DEBUG": OnDebugPacketReceived((DebugPacket)e.Packet); break;
                case "EDITMODE": OnEditModePacketReceived((EditModePacket)e.Packet); break;
                case "EDITOBJECT": OnEditObjectPacketReceived((EditObjectPacket)e.Packet); break;
                case "FOCUS": OnFocusPacketReceived((FocusPacket)e.Packet); break;
                case "GMISC": OnGuildMiscellaneousPacketReceived((GuildMiscellaneousPacket)e.Packet); break;
                case "GOODBYE": OnGoodbyePacketReceived((GoodbyePacket)e.Packet); break;
                case "GV": OnGetVariablePacketReceived((GetVariablePacket)e.Packet); break;
                case "HANDSHAKE": OnHandshakePacketReceived((HandshakePacket)e.Packet); break;
                case "HB": OnHealthBarPacketReceived((HealthBarPacket)e.Packet); break;
                case "HIDEOBJ": OnHideObjectPacketReceived((HideObjectPacket)e.Packet); break;
                case "HOUSEITEMTAB": OnHouseItemTabPacketReceived((HouseItemTabPacket)e.Packet); break;
                case "INITBAR": OnInitializationBarPacketReceived((InitializationBarPacket)e.Packet); break;
                case "INV": OnInventoryPacketReceived((InventoryPacket)e.Packet); break;
                case "JOIN": OnJoinPacketReceived((JoinPacket)e.Packet); break;
                case "LEAVE": OnLeavePacketReceived((LeavePacket)e.Packet); break;
                case "LOADPANEL": OnLoadPanelPacketReceived((LoadPanelPacket)e.Packet); break;
                case "LOADPIC": OnLoadPicturePacketReceived((LoadPicturePacket)e.Packet); break;
                case "LOCK": OnLockPacketReceived((LockPacket)e.Packet); break;
                case "LOGINREPLY": OnLoginReplyPacketReceived((LoginReplyPacket)e.Packet); break;
                case "MEATTRIB": OnMeAttributePacketReceived((MeAttributePacket)e.Packet); break;
                case "MISC": OnMiscellaneousPacketReceived((MiscellaneousPacket)e.Packet); break;
                case "MODIFYBAGITEM": OnModifyBagItemPacketReceived((ModifyBagItemPacket)e.Packet); break;
                case "MODOBJ": OnModifyObjectPacketReceived((ModifyObjectPacket)e.Packet); break;
                case "MOVE": OnMovePacketReceived((MovePacket)e.Packet); break;
                case "MOVEOBJ": OnMoveObjectPacketReceived((MoveObjectPacket)e.Packet); break;
                case "MOVEOBJ2": OnMoveObjectOtherPacketReceived((MoveObjectOtherPacket)e.Packet); break;
                case "MSGBOX": OnMessageBoxPacketReceived((MessageBoxPacket)e.Packet); break;
                case "NEWLOCKBOX": OnNewLockBoxPacketReceived((NewLockBoxPacket)e.Packet); break;
                case "NOFLOODWARNING": OnNoFloodWarningPacketReceived((NoFloodWarningPacket)e.Packet); break;
                case "OPENPANEL": OnOpenPanelPacketReceived((OpenPanelPacket)e.Packet); break;
                case "OPENURL": OnOpenUrlPacketReceived((OpenUrlPacket)e.Packet); break;
                case "OPENWINDOW": OnOpenWindowPacketReceived((OpenWindowPacket)e.Packet); break;
                case "PARTY": OnPartyPacketReceived((PartyPacket)e.Packet); break;
                case "PLAY": OnPlayPacketReceived((PlayPacket)e.Packet); break;
                case "PLAYERMENU": OnPlayerMenuPacketReceived((PlayerMenuPacket)e.Packet); break;
                case "REMCHAR": OnRemoveCharacterPacketReceived((RemoveCharacterPacket)e.Packet); break;
                case "REMOBJ": OnRemoveObjectPacketReceived((RemoveObjectPacket)e.Packet); break;
                case "REMOVEPLAYER": OnRemovePlayerPacketReceived((RemovePlayerPacket)e.Packet); break;
                case "SAY": OnSayPacketReceived((SayPacket)e.Packet); break;
                case "SBTEXTL": OnSpellBarTextLeftPacketReceived((SpellBarTextLeftPacket)e.Packet); break;
                case "SBTEXTR": OnSpellBarTextRightPacketReceived((SpellBarTextRightPacket)e.Packet); break;
                case "SELECTED": OnSelectedPacketReceived((SelectedPacket)e.Packet); break;
                case "SETACTION": OnSetActionPacketReceived((SetActionPacket)e.Packet); break;
                case "SETCLIPS": OnSetClipsPacketReceived((SetClipsPacket)e.Packet); break;
                case "SETSKILL": OnSetSkillPacketReceived((SetSkillPacket)e.Packet); break;
                case "SETSKILLBAR": OnSetSkillBarPacketReceived((SetSkillBarPacket)e.Packet); break;
                case "SETSPELLBAR": OnSetSpellBarPacketReceived((SetSpellBarPacket)e.Packet); break;
                case "SETTEXT": OnSetTextPacketReceived((SetTextPacket)e.Packet); break;
                case "SHOWHOUSELOCK": OnShowHouseLockPacketReceived((ShowHouseLockPacket)e.Packet); break;
                case "SHOWOBJ": OnShowObjectPacketReceived((ShowObjectPacket)e.Packet); break;
                case "SKINNING": OnSkinningPacketReceived((SkinningPacket)e.Packet); break;
                case "SOUND": OnSoundPacketReceived((SoundPacket)e.Packet); break;
                case "SOUNDTOGGLE": OnSoundTogglePacketReceived((SoundTogglePacket)e.Packet); break;
                case "SPECBAR": OnSpecBarPacketReceived((SpecBarPacket)e.Packet); break;
                case "SPELL": OnSpellPacketReceived((SpellPacket)e.Packet); break;
                case "STAT": OnStatisticPacketReceived((StatisticPacket)e.Packet); break;
                case "STATUS": OnStatusPacketReceived((StatusPacket)e.Packet); break;
                case "STOP": OnStopPacketReceived((StopPacket)e.Packet); break;
                case "SV": OnSetVariablePacketReceived((SetVariablePacket)e.Packet); break;
                case "TAKEFROMBAG": OnTakeFromBagPacketReceived((TakeFromBagPacket)e.Packet); break;
                case "TICK": OnTickPacketReceived((TickPacket)e.Packet); break;
                case "TOOLICON": OnToolIconPacketReceived((ToolIconPacket)e.Packet); break;
                case "TRADEWINDOW": OnTradeWindowPacketReceived((TradeWindowPacket)e.Packet); break;
                case "WARP": OnWarpPacketReceived((WarpPacket)e.Packet); break;
                case "WEATHER": OnWeatherPacketReceived((WeatherPacket)e.Packet); break;
                case "WLEVEL": OnWLevelPacketReceived((WLevelPacket)e.Packet); break;
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

        private void OnAttackPacketReceived(AttackPacket packet) { OnAttackPacketReceived(new AttackPacketReceivedEventArgs(packet)); }
        private void OnAttackPacketReceived(AttackPacketReceivedEventArgs e)
        {
            if (AttackPacketReceived != null) AttackPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnAttributePacketReceived(AttributePacket packet) { OnAttributePacketReceived(new AttributePacketReceivedEventArgs(packet)); }
        private void OnAttributePacketReceived(AttributePacketReceivedEventArgs e)
        {
            if (AttributePacketReceived != null) AttributePacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnBackgroundColorPacketReceived(BackgroundColorPacket packet) { OnBackgroundColorPacketReceived(new BackgroundColorPacketReceivedEventArgs(packet)); }
        private void OnBackgroundColorPacketReceived(BackgroundColorPacketReceivedEventArgs e)
        {
            if (BackgroundColorPacketReceived != null) BackgroundColorPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnBattleTextMiscellaneousPacketReceived(BattleTextMiscellaneousPacket packet) { OnBattleTextMiscellaneousPacketReceived(new BattleTextMiscellaneousPacketReceivedEventArgs(packet)); }
        private void OnBattleTextMiscellaneousPacketReceived(BattleTextMiscellaneousPacketReceivedEventArgs e)
        {
            if (BattleTextMiscellaneousPacketReceived != null) BattleTextMiscellaneousPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnChatChannelPacketReceived(ChatChannelPacket packet) { OnChatChannelPacketReceived(new ChatChannelPacketReceivedEventArgs(packet)); }
        private void OnChatChannelPacketReceived(ChatChannelPacketReceivedEventArgs e)
        {
            if (ChatChannelPacketReceived != null) ChatChannelPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnCharacterAttributePacketReceived(CharacterAttributePacket packet) { OnCharacterAttributePacketReceived(new CharacterAttributePacketReceivedEventArgs(packet)); }
        private void OnCharacterAttributePacketReceived(CharacterAttributePacketReceivedEventArgs e)
        {
            if (CharacterAttributePacketReceived != null) CharacterAttributePacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnClearSpellPacketReceived(ClearSpellPacket packet) { OnClearSpellPacketReceived(new ClearSpellPacketReceivedEventArgs(packet)); }
        private void OnClearSpellPacketReceived(ClearSpellPacketReceivedEventArgs e)
        {
            if (ClearSpellPacketReceived != null) ClearSpellPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnCloseLootPacketReceived(CloseLootPacket packet) { OnCloseLootPacketReceived(new CloseLootPacketReceivedEventArgs(packet)); }
        private void OnCloseLootPacketReceived(CloseLootPacketReceivedEventArgs e)
        {
            if (CloseLootPacketReceived != null) CloseLootPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnCloseWindowPacketReceived(CloseWindowPacket packet) { OnCloseWindowPacketReceived(new CloseWindowPacketReceivedEventArgs(packet)); }
        private void OnCloseWindowPacketReceived(CloseWindowPacketReceivedEventArgs e)
        {
            if (CloseWindowPacketReceived != null) CloseWindowPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnConfigurationPacketReceived(ConfigurationPacket packet) { OnConfigurationPacketReceived(new ConfigurationPacketReceivedEventArgs(packet)); }
        private void OnConfigurationPacketReceived(ConfigurationPacketReceivedEventArgs e)
        {
            if (ConfigurationPacketReceived != null) ConfigurationPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnDebugPacketReceived(DebugPacket packet) { OnDebugPacketReceived(new DebugPacketReceivedEventArgs(packet)); }
        private void OnDebugPacketReceived(DebugPacketReceivedEventArgs e)
        {
            if (DebugPacketReceived != null) DebugPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnEditModePacketReceived(EditModePacket packet) { OnEditModePacketReceived(new EditModePacketReceivedEventArgs(packet)); }
        private void OnEditModePacketReceived(EditModePacketReceivedEventArgs e)
        {
            if (EditModePacketReceived != null) EditModePacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnEditObjectPacketReceived(EditObjectPacket packet) { OnEditObjectPacketReceived(new EditObjectPacketReceivedEventArgs(packet)); }
        private void OnEditObjectPacketReceived(EditObjectPacketReceivedEventArgs e)
        {
            if (EditObjectPacketReceived != null) EditObjectPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnFocusPacketReceived(FocusPacket packet) { OnFocusPacketReceived(new FocusPacketReceivedEventArgs(packet)); }
        private void OnFocusPacketReceived(FocusPacketReceivedEventArgs e)
        {
            if (FocusPacketReceived != null) FocusPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnGuildMiscellaneousPacketReceived(GuildMiscellaneousPacket packet) { OnGuildMiscellaneousPacketReceived(new GuildMiscellaneousPacketReceivedEventArgs(packet)); }
        private void OnGuildMiscellaneousPacketReceived(GuildMiscellaneousPacketReceivedEventArgs e)
        {
            if (GuildMiscellaneousPacketReceived != null) GuildMiscellaneousPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnGoodbyePacketReceived(GoodbyePacket packet) { OnGoodbyePacketReceived(new GoodbyePacketReceivedEventArgs(packet)); }
        private void OnGoodbyePacketReceived(GoodbyePacketReceivedEventArgs e)
        {
            if (GoodbyePacketReceived != null) GoodbyePacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnGetVariablePacketReceived(GetVariablePacket packet) { OnGetVariablePacketReceived(new GetVariablePacketReceivedEventArgs(packet)); }
        private void OnGetVariablePacketReceived(GetVariablePacketReceivedEventArgs e)
        {
            if (GetVariablePacketReceived != null) GetVariablePacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnHandshakePacketReceived(HandshakePacket packet) { OnHandshakePacketReceived(new HandshakePacketReceivedEventArgs(packet)); }
        private void OnHandshakePacketReceived(HandshakePacketReceivedEventArgs e)
        {
            if (HandshakePacketReceived != null) HandshakePacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnHealthBarPacketReceived(HealthBarPacket packet) { OnHealthBarPacketReceived(new HealthBarPacketReceivedEventArgs(packet)); }
        private void OnHealthBarPacketReceived(HealthBarPacketReceivedEventArgs e)
        {
            if (HealthBarPacketReceived != null) HealthBarPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnHideObjectPacketReceived(HideObjectPacket packet) { OnHideObjectPacketReceived(new HideObjectPacketReceivedEventArgs(packet)); }
        private void OnHideObjectPacketReceived(HideObjectPacketReceivedEventArgs e)
        {
            if (HideObjectPacketReceived != null) HideObjectPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnHouseItemTabPacketReceived(HouseItemTabPacket packet) { OnHouseItemTabPacketReceived(new HouseItemTabPacketReceivedEventArgs(packet)); }
        private void OnHouseItemTabPacketReceived(HouseItemTabPacketReceivedEventArgs e)
        {
            if (HouseItemTabPacketReceived != null) HouseItemTabPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnInitializationBarPacketReceived(InitializationBarPacket packet) { OnInitializationBarPacketReceived(new InitializationBarPacketReceivedEventArgs(packet)); }
        private void OnInitializationBarPacketReceived(InitializationBarPacketReceivedEventArgs e)
        {
            if (InitializationBarPacketReceived != null) InitializationBarPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnInventoryPacketReceived(InventoryPacket packet) { OnInventoryPacketReceived(new InventoryPacketReceivedEventArgs(packet)); }
        private void OnInventoryPacketReceived(InventoryPacketReceivedEventArgs e)
        {
            if (InventoryPacketReceived != null) InventoryPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnJoinPacketReceived(JoinPacket packet) { OnJoinPacketReceived(new JoinPacketReceivedEventArgs(packet)); }
        private void OnJoinPacketReceived(JoinPacketReceivedEventArgs e)
        {
            if (JoinPacketReceived != null) JoinPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnLeavePacketReceived(LeavePacket packet) { OnLeavePacketReceived(new LeavePacketReceivedEventArgs(packet)); }
        private void OnLeavePacketReceived(LeavePacketReceivedEventArgs e)
        {
            if (LeavePacketReceived != null) LeavePacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnLoadPanelPacketReceived(LoadPanelPacket packet) { OnLoadPanelPacketReceived(new LoadPanelPacketReceivedEventArgs(packet)); }
        private void OnLoadPanelPacketReceived(LoadPanelPacketReceivedEventArgs e)
        {
            if (LoadPanelPacketReceived != null) LoadPanelPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnLoadPicturePacketReceived(LoadPicturePacket packet) { OnLoadPicturePacketReceived(new LoadPicturePacketReceivedEventArgs(packet)); }
        private void OnLoadPicturePacketReceived(LoadPicturePacketReceivedEventArgs e)
        {
            if (LoadPicturePacketReceived != null) LoadPicturePacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnLockPacketReceived(LockPacket packet) { OnLockPacketReceived(new LockPacketReceivedEventArgs(packet)); }
        private void OnLockPacketReceived(LockPacketReceivedEventArgs e)
        {
            if (LockPacketReceived != null) LockPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }


        private void OnLoginReplyPacketReceived(LoginReplyPacket packet) { OnLoginReplyPacketReceived(new LoginReplyPacketReceivedEventArgs(packet)); }
        private void OnLoginReplyPacketReceived(LoginReplyPacketReceivedEventArgs e)
        {
            if (LoginReplyPacketReceived != null) LoginReplyPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnMeAttributePacketReceived(MeAttributePacket packet) { OnMeAttributePacketReceived(new MeAttributePacketReceivedEventArgs(packet)); }
        private void OnMeAttributePacketReceived(MeAttributePacketReceivedEventArgs e)
        {
            if (MeAttributePacketReceived != null) MeAttributePacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnMiscellaneousPacketReceived(MiscellaneousPacket packet) { OnMiscellaneousPacketReceived(new MiscellaneousPacketReceivedEventArgs(packet)); }
        private void OnMiscellaneousPacketReceived(MiscellaneousPacketReceivedEventArgs e)
        {
            if (MiscellaneousPacketReceived != null) MiscellaneousPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnModifyBagItemPacketReceived(ModifyBagItemPacket packet) { OnModifyBagItemPacketReceived(new ModifyBagItemPacketReceivedEventArgs(packet)); }
        private void OnModifyBagItemPacketReceived(ModifyBagItemPacketReceivedEventArgs e)
        {
            if (ModifyBagItemPacketReceived != null) ModifyBagItemPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnModifyObjectPacketReceived(ModifyObjectPacket packet) { OnModifyObjectPacketReceived(new ModifyObjectPacketReceivedEventArgs(packet)); }
        private void OnModifyObjectPacketReceived(ModifyObjectPacketReceivedEventArgs e)
        {
            if (ModifyObjectPacketReceived != null) ModifyObjectPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnMovePacketReceived(MovePacket packet) { OnMovePacketReceived(new MovePacketReceivedEventArgs(packet)); }
        private void OnMovePacketReceived(MovePacketReceivedEventArgs e)
        {
            if (MovePacketReceived != null) MovePacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnMoveObjectPacketReceived(MoveObjectPacket packet) { OnMoveObjectPacketReceived(new MoveObjectPacketReceivedEventArgs(packet)); }
        private void OnMoveObjectPacketReceived(MoveObjectPacketReceivedEventArgs e)
        {
            if (MoveObjectPacketReceived != null) MoveObjectPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnMoveObjectOtherPacketReceived(MoveObjectOtherPacket packet) { OnMoveObjectOtherPacketReceived(new MoveObjectOtherPacketReceivedEventArgs(packet)); }
        private void OnMoveObjectOtherPacketReceived(MoveObjectOtherPacketReceivedEventArgs e)
        {
            if (MoveObjectOtherPacketReceived != null) MoveObjectOtherPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnMessageBoxPacketReceived(MessageBoxPacket packet) { OnMessageBoxPacketReceived(new MessageBoxPacketReceivedEventArgs(packet)); }
        private void OnMessageBoxPacketReceived(MessageBoxPacketReceivedEventArgs e)
        {
            if (MessageBoxPacketReceived != null) MessageBoxPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnNewLockBoxPacketReceived(NewLockBoxPacket packet) { OnNewLockBoxPacketReceived(new NewLockBoxPacketReceivedEventArgs(packet)); }
        private void OnNewLockBoxPacketReceived(NewLockBoxPacketReceivedEventArgs e)
        {
            if (NewLockBoxPacketReceived != null) NewLockBoxPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnNoFloodWarningPacketReceived(NoFloodWarningPacket packet) { OnNoFloodWarningPacketReceived(new NoFloodWarningPacketReceivedEventArgs(packet)); }
        private void OnNoFloodWarningPacketReceived(NoFloodWarningPacketReceivedEventArgs e)
        {
            if (NoFloodWarningPacketReceived != null) NoFloodWarningPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnOpenPanelPacketReceived(OpenPanelPacket packet) { OnOpenPanelPacketReceived(new OpenPanelPacketReceivedEventArgs(packet)); }
        private void OnOpenPanelPacketReceived(OpenPanelPacketReceivedEventArgs e)
        {
            if (OpenPanelPacketReceived != null) OpenPanelPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnOpenUrlPacketReceived(OpenUrlPacket packet) { OnOpenUrlPacketReceived(new OpenUrlPacketReceivedEventArgs(packet)); }
        private void OnOpenUrlPacketReceived(OpenUrlPacketReceivedEventArgs e)
        {
            if (OpenUrlPacketReceived != null) OpenUrlPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnOpenWindowPacketReceived(OpenWindowPacket packet) { OnOpenWindowPacketReceived(new OpenWindowPacketReceivedEventArgs(packet)); }
        private void OnOpenWindowPacketReceived(OpenWindowPacketReceivedEventArgs e)
        {
            if (OpenWindowPacketReceived != null) OpenWindowPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnPartyPacketReceived(PartyPacket packet) { OnPartyPacketReceived(new PartyPacketReceivedEventArgs(packet)); }
        private void OnPartyPacketReceived(PartyPacketReceivedEventArgs e)
        {
            if (PartyPacketReceived != null) PartyPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnPlayPacketReceived(PlayPacket packet) { OnPlayPacketReceived(new PlayPacketReceivedEventArgs(packet)); }
        private void OnPlayPacketReceived(PlayPacketReceivedEventArgs e)
        {
            if (PlayPacketReceived != null) PlayPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnPlayerMenuPacketReceived(PlayerMenuPacket packet) { OnPlayerMenuPacketReceived(new PlayerMenuPacketReceivedEventArgs(packet)); }
        private void OnPlayerMenuPacketReceived(PlayerMenuPacketReceivedEventArgs e)
        {
            if (PlayerMenuPacketReceived != null) PlayerMenuPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnRemoveCharacterPacketReceived(RemoveCharacterPacket packet) { OnRemoveCharacterPacketReceived(new RemoveCharacterPacketReceivedEventArgs(packet)); }
        private void OnRemoveCharacterPacketReceived(RemoveCharacterPacketReceivedEventArgs e)
        {
            if (RemoveCharacterPacketReceived != null) RemoveCharacterPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnRemoveObjectPacketReceived(RemoveObjectPacket packet) { OnRemoveObjectPacketReceived(new RemoveObjectPacketReceivedEventArgs(packet)); }
        private void OnRemoveObjectPacketReceived(RemoveObjectPacketReceivedEventArgs e)
        {
            if (RemoveObjectPacketReceived != null) RemoveObjectPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnRemovePlayerPacketReceived(RemovePlayerPacket packet) { OnRemovePlayerPacketReceived(new RemovePlayerPacketReceivedEventArgs(packet)); }
        private void OnRemovePlayerPacketReceived(RemovePlayerPacketReceivedEventArgs e)
        {
            if (RemovePlayerPacketReceived != null) RemovePlayerPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnSayPacketReceived(SayPacket packet) { OnSayPacketReceived(new SayPacketReceivedEventArgs(packet)); }
        private void OnSayPacketReceived(SayPacketReceivedEventArgs e)
        {
            if (SayPacketReceived != null) SayPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnSpellBarTextLeftPacketReceived(SpellBarTextLeftPacket packet) { OnSpellBarTextLeftPacketReceived(new SpellBarTextLeftPacketReceivedEventArgs(packet)); }
        private void OnSpellBarTextLeftPacketReceived(SpellBarTextLeftPacketReceivedEventArgs e)
        {
            if (SpellBarTextLeftPacketReceived != null) SpellBarTextLeftPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnSpellBarTextRightPacketReceived(SpellBarTextRightPacket packet) { OnSpellBarTextRightPacketReceived(new SpellBarTextRightPacketReceivedEventArgs(packet)); }
        private void OnSpellBarTextRightPacketReceived(SpellBarTextRightPacketReceivedEventArgs e)
        {
            if (SpellBarTextRightPacketReceived != null) SpellBarTextRightPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnSelectedPacketReceived(SelectedPacket packet) { OnSelectedPacketReceived(new SelectedPacketReceivedEventArgs(packet)); }
        private void OnSelectedPacketReceived(SelectedPacketReceivedEventArgs e)
        {
            if (SelectedPacketReceived != null) SelectedPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnSetActionPacketReceived(SetActionPacket packet) { OnSetActionPacketReceived(new SetActionPacketReceivedEventArgs(packet)); }
        private void OnSetActionPacketReceived(SetActionPacketReceivedEventArgs e)
        {
            if (SetActionPacketReceived != null) SetActionPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnSetClipsPacketReceived(SetClipsPacket packet) { OnSetClipsPacketReceived(new SetClipsPacketReceivedEventArgs(packet)); }
        private void OnSetClipsPacketReceived(SetClipsPacketReceivedEventArgs e)
        {
            if (SetClipsPacketReceived != null) SetClipsPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnSetSkillPacketReceived(SetSkillPacket packet) { OnSetSkillPacketReceived(new SetSkillPacketReceivedEventArgs(packet)); }
        private void OnSetSkillPacketReceived(SetSkillPacketReceivedEventArgs e)
        {
            if (SetSkillPacketReceived != null) SetSkillPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnSetSkillBarPacketReceived(SetSkillBarPacket packet) { OnSetSkillBarPacketReceived(new SetSkillBarPacketReceivedEventArgs(packet)); }
        private void OnSetSkillBarPacketReceived(SetSkillBarPacketReceivedEventArgs e)
        {
            if (SetSkillBarPacketReceived != null) SetSkillBarPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnSetSpellBarPacketReceived(SetSpellBarPacket packet) { OnSetSpellBarPacketReceived(new SetSpellBarPacketReceivedEventArgs(packet)); }
        private void OnSetSpellBarPacketReceived(SetSpellBarPacketReceivedEventArgs e)
        {
            if (SetSpellBarPacketReceived != null) SetSpellBarPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnSetTextPacketReceived(SetTextPacket packet) { OnSetTextPacketReceived(new SetTextPacketReceivedEventArgs(packet)); }
        private void OnSetTextPacketReceived(SetTextPacketReceivedEventArgs e)
        {
            if (SetTextPacketReceived != null) SetTextPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnShowHouseLockPacketReceived(ShowHouseLockPacket packet) { OnShowHouseLockPacketReceived(new ShowHouseLockPacketReceivedEventArgs(packet)); }
        private void OnShowHouseLockPacketReceived(ShowHouseLockPacketReceivedEventArgs e)
        {
            if (ShowHouseLockPacketReceived != null) ShowHouseLockPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnShowObjectPacketReceived(ShowObjectPacket packet) { OnShowObjectPacketReceived(new ShowObjectPacketReceivedEventArgs(packet)); }
        private void OnShowObjectPacketReceived(ShowObjectPacketReceivedEventArgs e)
        {
            if (ShowObjectPacketReceived != null) ShowObjectPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnSkinningPacketReceived(SkinningPacket packet) { OnSkinningPacketReceived(new SkinningPacketReceivedEventArgs(packet)); }
        private void OnSkinningPacketReceived(SkinningPacketReceivedEventArgs e)
        {
            if (SkinningPacketReceived != null) SkinningPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnSoundPacketReceived(SoundPacket packet) { OnSoundPacketReceived(new SoundPacketReceivedEventArgs(packet)); }
        private void OnSoundPacketReceived(SoundPacketReceivedEventArgs e)
        {
            if (SoundPacketReceived != null) SoundPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnSoundTogglePacketReceived(SoundTogglePacket packet) { OnSoundTogglePacketReceived(new SoundTogglePacketReceivedEventArgs(packet)); }
        private void OnSoundTogglePacketReceived(SoundTogglePacketReceivedEventArgs e)
        {
            if (SoundTogglePacketReceived != null) SoundTogglePacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnSpecBarPacketReceived(SpecBarPacket packet) { OnSpecBarPacketReceived(new SpecBarPacketReceivedEventArgs(packet)); }
        private void OnSpecBarPacketReceived(SpecBarPacketReceivedEventArgs e)
        {
            if (SpecBarPacketReceived != null) SpecBarPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnSpellPacketReceived(SpellPacket packet) { OnSpellPacketReceived(new SpellPacketReceivedEventArgs(packet)); }
        private void OnSpellPacketReceived(SpellPacketReceivedEventArgs e)
        {
            if (SpellPacketReceived != null) SpellPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnStatisticPacketReceived(StatisticPacket packet) { OnStatisticPacketReceived(new StatisticPacketReceivedEventArgs(packet)); }
        private void OnStatisticPacketReceived(StatisticPacketReceivedEventArgs e)
        {
            if (StatisticPacketReceived != null) StatisticPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnStatusPacketReceived(StatusPacket packet) { OnStatusPacketReceived(new StatusPacketReceivedEventArgs(packet)); }
        private void OnStatusPacketReceived(StatusPacketReceivedEventArgs e)
        {
            if (StatusPacketReceived != null) StatusPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnStopPacketReceived(StopPacket packet) { OnStopPacketReceived(new StopPacketReceivedEventArgs(packet)); }
        private void OnStopPacketReceived(StopPacketReceivedEventArgs e)
        {
            if (StopPacketReceived != null) StopPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnSetVariablePacketReceived(SetVariablePacket packet) { OnSetVariablePacketReceived(new SetVariablePacketReceivedEventArgs(packet)); }
        private void OnSetVariablePacketReceived(SetVariablePacketReceivedEventArgs e)
        {
            if (SetVariablePacketReceived != null) SetVariablePacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnTakeFromBagPacketReceived(TakeFromBagPacket packet) { OnTakeFromBagPacketReceived(new TakeFromBagPacketReceivedEventArgs(packet)); }
        private void OnTakeFromBagPacketReceived(TakeFromBagPacketReceivedEventArgs e)
        {
            if (TakeFromBagPacketReceived != null) TakeFromBagPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnTickPacketReceived(TickPacket packet) { OnTickPacketReceived(new TickPacketReceivedEventArgs(packet)); }
        private void OnTickPacketReceived(TickPacketReceivedEventArgs e)
        {
            if (TickPacketReceived != null) TickPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnToolIconPacketReceived(ToolIconPacket packet) { OnToolIconPacketReceived(new ToolIconPacketReceivedEventArgs(packet)); }
        private void OnToolIconPacketReceived(ToolIconPacketReceivedEventArgs e)
        {
            if (ToolIconPacketReceived != null) ToolIconPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnTradeWindowPacketReceived(TradeWindowPacket packet) { OnTradeWindowPacketReceived(new TradeWindowPacketReceivedEventArgs(packet)); }
        private void OnTradeWindowPacketReceived(TradeWindowPacketReceivedEventArgs e)
        {
            if (TradeWindowPacketReceived != null) TradeWindowPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnWarpPacketReceived(WarpPacket packet) { OnWarpPacketReceived(new WarpPacketReceivedEventArgs(packet)); }
        private void OnWarpPacketReceived(WarpPacketReceivedEventArgs e)
        {
            if (WarpPacketReceived != null) WarpPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnWeatherPacketReceived(WeatherPacket packet) { OnWeatherPacketReceived(new WeatherPacketReceivedEventArgs(packet)); }
        private void OnWeatherPacketReceived(WeatherPacketReceivedEventArgs e)
        {
            if (WeatherPacketReceived != null) WeatherPacketReceived(this, e);
            else OnAbstractPacketReceived(e);
        }

        private void OnWLevelPacketReceived(WLevelPacket packet) { OnWLevelPacketReceived(new WLevelPacketReceivedEventArgs(packet)); }
        private void OnWLevelPacketReceived(WLevelPacketReceivedEventArgs e)
        {
            if (WLevelPacketReceived != null) WLevelPacketReceived(this, e);
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
