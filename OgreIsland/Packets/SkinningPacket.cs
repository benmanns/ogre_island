namespace OgreIsland.Packets
{
    public class SkinningPacket : AbstractPacket
    {
        public SkinningPacket() : base(new Packet("SKINNING", null)) { }
        public SkinningPacket(Packet packet) : base(packet) { }
    }
}
