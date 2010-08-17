namespace OgreIsland.Packets
{
    public class LoginPacket : AbstractPacket
    {
        public LoginPacket() : base(new Packet("LOGIN", new string[3])) { }
        public LoginPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Authentication { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Version { get { return Arguments[2]; } set { Arguments[2] = value; } }
    }
}
