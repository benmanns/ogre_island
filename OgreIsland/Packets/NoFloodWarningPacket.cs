namespace OgreIsland.Packets
{
    public class NoFloodWarningPacket : AbstractPacket
    {
        public NoFloodWarningPacket() : base(new Packet("NOFLOODWARNING", null)) { }
        public NoFloodWarningPacket(Packet packet) : base(packet) { }
    }
}
