namespace OgreIsland.Packets
{
    public class SpecBarPacket : AbstractPacket
    {
        public SpecBarPacket() : base(new Packet("SPECBAR", new string[1])) { }
        public SpecBarPacket(Packet packet) : base(packet) { }
        public string Time { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
