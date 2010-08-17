namespace OgreIsland.Packets
{
    public class HideObjectPacket : AbstractPacket
    {
        public HideObjectPacket() : base(new Packet("HIDEOBJ", new string[1])) { }
        public HideObjectPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
