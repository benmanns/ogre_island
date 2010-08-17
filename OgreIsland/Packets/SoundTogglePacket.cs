namespace OgreIsland.Packets
{
    public class SoundTogglePacket : AbstractPacket
    {
        public SoundTogglePacket() : base(new Packet("SOUNDTOGGLE", new string[1])) { }
        public SoundTogglePacket(Packet packet) : base(packet) { }
        public string Frame { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
