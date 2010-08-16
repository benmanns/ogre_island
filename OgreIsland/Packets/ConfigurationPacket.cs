namespace OgreIsland.Packets
{
    public class ConfigurationPacket : AbstractPacket
    {
        public ConfigurationPacket() : base(new Packet("CONFIG", new string[2])) { }
        public ConfigurationPacket(Packet packet) : base(packet) { }
        public string Parameter { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Value { get { return Arguments[1]; } set { Arguments[1] = value; } }
    }
}
