namespace OgreIsland.Packets
{
    public class OpenWindowPacket : AbstractPacket
    {
        public OpenWindowPacket() : base(new Packet("OPENWINDOW", new string[4])) { }
        public OpenWindowPacket(Packet packet) : base(packet) { }
        public string Window { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Text { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Title { get { return Arguments[2]; } set { Arguments[2] = value; } }
        public string Icon { get { return Arguments[3]; } set { Arguments[3] = value; } }
    }
}
