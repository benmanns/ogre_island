namespace OgreIsland.Packets
{
    public class StatisticPacket : AbstractPacket
    {
        public StatisticPacket() : base(new Packet("STAT", new string[4])) { }
        public StatisticPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Attribute { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Value { get { return Arguments[2]; } set { Arguments[2] = value; } }
        public string Maximum { get { return Arguments[3]; } set { Arguments[3] = value; } }
    }
}
