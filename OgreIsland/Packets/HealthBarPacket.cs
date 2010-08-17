namespace OgreIsland.Packets
{
    public class HealthBarPacket : AbstractPacket
    {
        public HealthBarPacket() : base(new Packet("HB", new string[4])) { }
        public HealthBarPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Toggle { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Value { get { return Arguments[2]; } set { Arguments[2] = value; } }
        public string Maximum { get { return Arguments[3]; } set { Arguments[3] = value; } }
    }
}
