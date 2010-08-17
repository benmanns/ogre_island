namespace OgreIsland.Packets
{
    public class JoinPacket : AbstractPacket
    {
        public JoinPacket() : base(new Packet("JOIN", new string[1])) { }
        public JoinPacket(Packet packet) : base(packet) { }
        public string Name { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
