namespace OgreIsland.Packets
{
    public class PlayPacket : AbstractPacket
    {
        public PlayPacket() : base(new Packet("PLAY", null)) { }
        public PlayPacket(Packet packet) : base(packet) { }
    }
}
