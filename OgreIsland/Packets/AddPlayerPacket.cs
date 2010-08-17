namespace OgreIsland.Packets
{
    public class AddPlayerPacket : AbstractPacket
    {
        public AddPlayerPacket() : base(new Packet("ADDPLAYER", new string[2])) { }
        public AddPlayerPacket(Packet packet) : base(packet) { }
        public string Name { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Display { get { return Arguments[1]; } set { Arguments[1] = value; } }
    }
}
