namespace OgreIsland.Packets
{
    public class ShowObjectPacket : AbstractPacket
    {
        public ShowObjectPacket() : base(new Packet("SHOWOBJ", new string[1])) { }
        public ShowObjectPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
