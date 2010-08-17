namespace OgreIsland.Packets
{
    public class SetSpellBarPacket : AbstractPacket
    {
        public SetSpellBarPacket() : base(new Packet("SETSPELLBAR", new string[3])) { }
        public SetSpellBarPacket(Packet packet) : base(packet) { }
        public string Name { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Frame { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Tip { get { return Arguments[2]; } set { Arguments[2] = value; } }
    }
}
