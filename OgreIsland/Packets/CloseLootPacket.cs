namespace OgreIsland.Packets
{
    public class CloseLootPacket : AbstractPacket
    {
        public CloseLootPacket() : base(new Packet("CLOSELOOT", null)) { }
        public CloseLootPacket(Packet packet) : base(packet) { }
    }
}
