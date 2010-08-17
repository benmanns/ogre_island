namespace OgreIsland.Packets
{
    public class InitializationBarPacket : AbstractPacket
    {
        public InitializationBarPacket() : base(new Packet("INITBAR", new string[1])) { }
        public InitializationBarPacket(Packet packet) : base(packet) { }
        public string Time { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
