namespace OgreIsland.Packets
{
    public class MeAttributePacket : AbstractPacket
    {
        public MeAttributePacket() : base(new Packet("MEATTRIB", new string[2])) { }
        public MeAttributePacket(Packet packet) : base(packet) { }
        public string Attribute { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Value { get { return Arguments[1]; } set { Arguments[1] = value; } }
    }
}
