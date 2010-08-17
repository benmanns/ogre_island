namespace OgreIsland.Packets
{
    public class OpenUrlPacket : AbstractPacket
    {
        public OpenUrlPacket() : base(new Packet("OPENURL", new string[2])) { }
        public OpenUrlPacket(Packet packet) : base(packet) { }
        public string Uri { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Target { get { return Arguments[1]; } set { Arguments[1] = value; } }
    }
}
