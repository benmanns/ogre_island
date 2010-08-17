namespace OgreIsland.Packets
{
    public class SoundPacket : AbstractPacket
    {
        public SoundPacket() : base(new Packet("SOUND", new string[2])) { }
        public SoundPacket(Packet packet) : base(packet) { }
        public string Name { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Loops { get { return Arguments[1]; } set { Arguments[1] = value; } }
    }
}
