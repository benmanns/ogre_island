namespace OgreIsland.Packets
{
    public class BackgroundColorPacket : AbstractPacket
    {
        public BackgroundColorPacket() : base(new Packet("BGCOLOR", new string[1])) { }
        public BackgroundColorPacket(Packet packet) : base(packet) { }
        public string BackgroundColor { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
