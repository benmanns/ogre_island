namespace OgreIsland.Packets
{
    public class DebugPacket : AbstractPacket
    {
        public DebugPacket() : base(new Packet("DEBUG", null)) { }
        public DebugPacket(Packet packet) : base(packet) { }
    }
}
