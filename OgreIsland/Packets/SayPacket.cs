namespace OgreIsland.Packets
{
    public class SayPacket : AbstractPacket
    {
        public SayPacket() : base(new Packet("SAY", new string[3])) { }
        public SayPacket(Packet packet) : base(packet) { }
        public string Name { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Text { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Channel { get { return Arguments[2]; } set { Arguments[2] = value; } }
    }
}
