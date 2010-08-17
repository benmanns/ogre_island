namespace OgreIsland.Packets
{
    public class SetTextPacket : AbstractPacket
    {
        public SetTextPacket() : base(new Packet("SETTEXT", new string[3])) { }
        public SetTextPacket(Packet packet) : base(packet) { }
        public string Window { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Variable { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Text { get { return Arguments[2]; } set { Arguments[2] = value; } }
    }
}
