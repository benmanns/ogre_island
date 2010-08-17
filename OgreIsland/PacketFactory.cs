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
                case "ATTACK": return new AttackPacket(packet);
                case "ATTRIB": return new AttributePacket(packet);
                case "BGCOLOR": return new BackgroundColorPacket(packet);
                case "BTMISC": return new BattleTextMiscellaneousPacket(packet);
                case "CCHANNEL": return new ChatChannelPacket(packet);
                case "CHARATTRIB": return new CharacterAttributePacket(packet);
                case "CLEARSPELL": return new ClearSpellPacket(packet);
                case "CLOSELOOT": return new CloseLootPacket(packet);
                case "CLOSEWINDOW": return new CloseWindowPacket(packet);
                case "CONFIG": return new ConfigurationPacket(packet);
                case "DEBUG": return new DebugPacket(packet);
                case "EDITMODE": return new EditModePacket(packet);
                case "EDITOBJECT": return new EditObjectPacket(packet);
                case "FOCUS": return new FocusPacket(packet);
                case "GMISC": return new GuildMiscellaneousPacket(packet);
                case "GOODBYE": return new GoodbyePacket(packet);
                case "GV": return new GetVariablePacket(packet);
                case "HANDSHAKE": return new HandshakePacket(packet);
                case "HB": return new HealthBarPacket(packet);
                case "HIDEOBJ": return new HideObjectPacket(packet);
                case "HOUSEITEMTAB": return new HouseItemTabPacket(packet);
                case "INITBAR": return new InitializationBarPacket(packet);
                case "INV": return new InventoryPacket(packet);
                case "JOIN": return new JoinPacket(packet);
                case "LEAVE": return new LeavePacket(packet);
                case "LOADPANEL": return new LoadPanelPacket(packet);
                case "LOADPIC": return new LoadPicturePacket(packet);
                case "LOCK": return new LockPacket(packet);
                case "LOGINREPLY": return new LoginReplyPacket(packet);
                case "MEATTRIB": return new MeAttributePacket(packet);
                case "MISC": return new MiscellaneousPacket(packet);
                case "MODIFYBAGITEM": return new ModifyBagItemPacket(packet);
                case "MODOBJ": return new ModifyObjectPacket(packet);
                case "MOVE": return new MovePacket(packet, Mode.Server);
                case "MOVEOBJ": return new MoveObjectPacket(packet);
                case "MOVEOBJ2": return new MoveObjectOtherPacket(packet);
                case "MSGBOX": return new MessageBoxPacket(packet);
                case "NEWLOCKBOX": return new NewLockBoxPacket(packet);
                case "NOFLOODWARNING": return new NoFloodWarningPacket(packet);
                case "OPENPANEL": return new OpenPanelPacket(packet);
                case "OPENURL": return new OpenUrlPacket(packet);
                case "OPENWINDOW": return new OpenWindowPacket(packet);
                case "PARTY": return new PartyPacket(packet);
                case "PLAY": return new PlayPacket(packet);
                case "PLAYERMENU": return new PlayerMenuPacket(packet);
                case "REMCHAR": return new RemoveCharacterPacket(packet);
                case "REMOBJ": return new RemoveObjectPacket(packet);
                case "REMOVEPLAYER": return new RemovePlayerPacket(packet);
                case "SAY": return new SayPacket(packet);
                case "SBTEXTL": return new SpellBarTextLeftPacket(packet);
                case "SBTEXTR": return new SpellBarTextRightPacket(packet);
                case "SELECTED": return new SelectedPacket(packet);
                default: return new AbstractPacket(packet);
            }
        }
    }
}
