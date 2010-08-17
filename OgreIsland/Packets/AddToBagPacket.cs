namespace OgreIsland.Packets
{
    public class AddToBagPacket : AbstractPacket
    {
        public AddToBagPacket() : base(new Packet("ADDTOBAG", new string[2])) { }
        public AddToBagPacket(Packet packet) : base(packet) { }
        public string BagName { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Itemstring { get { return Arguments[1]; } set { Arguments[1] = value; } }
    }
}
