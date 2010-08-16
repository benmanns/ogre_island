namespace OgreIsland.Packets
{
    public class FocusPacket : AbstractPacket
    {
        public FocusPacket() : base(new Packet("FOCUS", new string[1])) { }
        public FocusPacket(Packet packet) : base(packet) { }
        public string Zoom { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
