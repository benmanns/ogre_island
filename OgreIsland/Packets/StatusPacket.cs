namespace OgreIsland.Packets
{
    public class StatusPacket : AbstractPacket
    {
        public StatusPacket() : base(new Packet("STATUS", null)) { }
        public StatusPacket(Packet packet) : base(packet) { }
    }
}
