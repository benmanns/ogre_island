namespace OgreIsland.Packets
{
    public class WarpPacket : AbstractPacket
    {
        public WarpPacket() : base(new Packet("WARP", new string[6])) { }
        public WarpPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string X { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Y { get { return Arguments[2]; } set { Arguments[2] = value; } }
        public string Z { get { return Arguments[3]; } set { Arguments[3] = value; } }
        public string WLevel { get { return Arguments[4]; } set { Arguments[4] = value; } }
        public string ZSort { get { return Arguments[5]; } set { Arguments[5] = value; } }
    }
}
