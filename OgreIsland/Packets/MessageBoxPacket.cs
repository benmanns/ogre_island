namespace OgreIsland.Packets
{
    public class MessageBoxPacket : AbstractPacket
    {
        public MessageBoxPacket() : base(new Packet("MSGBOX", new string[4])) { }
        public MessageBoxPacket(Packet packet) : base(packet) { }
        public string Text { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Yes { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string No { get { return Arguments[2]; } set { Arguments[2] = value; } }
        public string Evaluation { get { return Arguments[3]; } set { Arguments[3] = value; } }
    }
}
