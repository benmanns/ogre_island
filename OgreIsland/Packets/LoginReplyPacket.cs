namespace OgreIsland.Packets
{
    public class LoginReplyPacket : AbstractPacket
    {
        public LoginReplyPacket() : base(new Packet("LOGINREPLY", new string[4])) { }
        public LoginReplyPacket(Packet packet) : base(packet) { }
        public string Status { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Name { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Id { get { return Arguments[2]; } set { Arguments[2] = value; } }
        public string Message { get { return Arguments[3]; } set { Arguments[3] = value; } }
    }
}
