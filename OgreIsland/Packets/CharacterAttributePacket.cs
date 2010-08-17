namespace OgreIsland.Packets
{
    public class CharacterAttributePacket : AbstractPacket
    {
        public CharacterAttributePacket() : base(new Packet("CHARATTRIB", new string[4])) { }
        public CharacterAttributePacket(Packet packet) : base(packet) { }
        public string Attribute { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Base { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Modification { get { return Arguments[2]; } set { Arguments[2] = value; } }
        public string Total { get { return Arguments[3]; } set { Arguments[3] = value; } }
    }
}
