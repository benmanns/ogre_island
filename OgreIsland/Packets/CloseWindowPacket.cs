namespace OgreIsland.Packets
{
    public class CloseWindowPacket : AbstractPacket
    {
        public CloseWindowPacket() : base(new Packet("CLOSEWINDOW", new string[1])) { }
        public CloseWindowPacket(Packet packet) : base(packet) { }
        public string Window { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
