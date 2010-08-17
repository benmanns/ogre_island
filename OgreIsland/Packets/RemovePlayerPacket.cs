namespace OgreIsland.Packets
{
    public class RemovePlayerPacket : AbstractPacket
    {
        public RemovePlayerPacket() : base(new Packet("REMOVEPLAYER", new string[1])) { }
        public RemovePlayerPacket(Packet packet) : base(packet) { }
        public string Name { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
