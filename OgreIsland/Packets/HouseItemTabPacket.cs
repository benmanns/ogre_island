namespace OgreIsland.Packets
{
    public class HouseItemTabPacket : AbstractPacket
    {
        public HouseItemTabPacket() : base(new Packet("HOUSEITEMTAB", new string[2])) { }
        public HouseItemTabPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Frame { get { return Arguments[1]; } set { Arguments[1] = value; } }    }
}
