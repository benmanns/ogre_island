namespace OgreIsland.Packets
{
    public class SpellBarTextLeftPacket : AbstractPacket
    {
        public SpellBarTextLeftPacket() : base(new Packet("SBTEXTL", new string[3])) { }
        public SpellBarTextLeftPacket(Packet packet) : base(packet) { }
        public string Type { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Text { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Uri { get { return Arguments[2]; } set { Arguments[2] = value; } }
    }
}
