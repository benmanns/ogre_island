namespace OgreIsland.Packets
{
    public class SpellBarTextRightPacket : AbstractPacket
    {
        public SpellBarTextRightPacket() : base(new Packet("SBTEXTR", new string[3])) { }
        public SpellBarTextRightPacket(Packet packet) : base(packet) { }
        public string Type { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Text { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Uri { get { return Arguments[2]; } set { Arguments[2] = value; } }
    }
}
