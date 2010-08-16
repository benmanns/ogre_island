using OgreIsland.Packets;

namespace OgreIsland
{
    public class AbstractPacket
    {
        protected Mode Mode { get; set; }
        public Packet Packet { get; private set; }
        public string Command { get { return Packet.Command; } set { Packet.Command = value; } }
        public string[] Arguments { get { return Packet.Arguments; } set { Packet.Arguments = value; } }
        public AbstractPacket(Packet packet) { Packet = packet; }
        public AbstractPacket(Packet packet, Mode mode) { Packet = packet; Mode = mode; }
    }
}
