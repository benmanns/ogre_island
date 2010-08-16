namespace OgreIsland.Packets
{
    public class AttributePacket : AbstractPacket
    {
        public AttributePacket() : base(new Packet("ATTRIB", new string[2])) { }
        public AttributePacket(Packet packet) : base(packet) { }
        public string Attribute { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Value { get { return Arguments[1]; } set { Arguments[1] = value; } }
    }
}
