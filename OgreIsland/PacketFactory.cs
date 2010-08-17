using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

using OgreIsland.Packets;

namespace OgreIsland
{
    public class PacketFactory
    {
        public static PacketList Create(Protocol protocol, List<byte> data)
        {
            switch (protocol)
            {
                case Protocol.Delimited:
                    {
                        string buffer = Encoding.ASCII.GetString(data.ToArray());
                        string[] parameters = buffer.Split((char)1);
                        string[] arguments = new string[parameters.Length - 1];
                        Array.Copy(parameters, 1, arguments, 0, arguments.Length);
                        Packet packet = new Packet(parameters[0], arguments);
                        return new PacketList(Cast(packet));
                    }
                case Protocol.Xml:
                    {
                        MemoryStream stream = new MemoryStream(data.ToArray());
                        XmlTextReader reader = new XmlTextReader(stream);
                        if (reader.Read())
                        {
                            PacketList packetList = new PacketList();
                            while (reader.Read() && reader.NodeType == XmlNodeType.Element)
                            {
                                string command = reader.GetAttribute(1);
                                string[] arguments = new string[reader.AttributeCount - 2];
                                for (int index = 2; index < reader.AttributeCount; index++)
                                    arguments[index - 2] = reader.GetAttribute(index);
                                Packet packet = new Packet(command, arguments);
                                packetList.Add(Cast(packet));
                            }
                            return packetList;
                        }
                        throw new InvalidDataException();
                    }
                default: throw new ArgumentOutOfRangeException();
            }
        }
        public static AbstractPacket Cast(AbstractPacket packet) { return Cast(packet.Packet); }
        public static AbstractPacket Cast(Packet packet)
        {
            switch (packet.Command)
            {
                case "ACTION": return new ActionPacket(packet);
                case "ADDCHAR": return new AddCharacterPacket(packet);
                case "ADDOBJ": return new AddObjectPacket(packet);
                case "ADDPLAYER": return new AddPlayerPacket(packet);
                case "ADDTOBAG": return new AddToBagPacket(packet);
                case "ADMIN": return new AdminPacket(packet);
                default: return new AbstractPacket(packet);
            }
        }
    }
}
