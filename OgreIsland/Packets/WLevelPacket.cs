namespace OgreIsland.Packets
{
    public class WLevelPacket : AbstractPacket
    {
        public WLevelPacket() : base(new Packet("WLEVEL", new string[2])) { }
        public WLevelPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Level { get { return Arguments[1]; } set { Arguments[1] = value; } }
    }
}
