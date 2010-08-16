using System.Collections.Generic;

namespace OgreIsland
{
    public class PacketList : List<AbstractPacket>
    {
        public PacketList(AbstractPacket packet) { Add(packet); }
        public PacketList(Packet packet) { Add(new AbstractPacket(packet)); }
        public PacketList(IEnumerable<AbstractPacket> packetList) { AddRange(packetList); }
        public PacketList() { }
    }
}
