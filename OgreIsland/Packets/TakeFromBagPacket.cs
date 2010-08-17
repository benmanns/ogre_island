namespace OgreIsland.Packets
{
    public class TakeFromBagPacket : AbstractPacket
    {
        public TakeFromBagPacket() : base(new Packet("TAKEFROMBAG", new string[2])) { }
        public TakeFromBagPacket(Packet packet) : base(packet) { }
        public string Bag { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Id { get { return Arguments[1]; } set { Arguments[1] = value; } }
    }
}
