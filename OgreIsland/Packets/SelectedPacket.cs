namespace OgreIsland.Packets
{
    public class SelectedPacket : AbstractPacket
    {
        public SelectedPacket() : base(new Packet("SELECTED", new string[7])) { }
        public SelectedPacket(Packet packet) : base(packet) { }
        public string Type { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Name { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Level { get { return Arguments[2]; } set { Arguments[2] = value; } }
        public string Group { get { return Arguments[3]; } set { Arguments[3] = value; } }
        public string ToHit { get { return Arguments[4]; } set { Arguments[4] = value; } }
        public string ArmorMelee { get { return Arguments[5]; } set { Arguments[5] = value; } }
        public string ArmorMagic { get { return Arguments[6]; } set { Arguments[6] = value; } }
    }
}
