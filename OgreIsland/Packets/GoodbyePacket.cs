namespace OgreIsland.Packets
{
    public class GoodbyePacket : AbstractPacket
    {
        public GoodbyePacket() : base(new Packet("GOODBYE", new string[1])) { }
        public GoodbyePacket(Packet packet) : base(packet) { }
        public string Message { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
