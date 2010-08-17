namespace OgreIsland.Packets
{
    public class LoadPicturePacket : AbstractPacket
    {
        public LoadPicturePacket() : base(new Packet("LOADPIC", new string[2])) { }
        public LoadPicturePacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Uri { get { return Arguments[1]; } set { Arguments[1] = value; } }
    }
}
