namespace OgreIsland.Packets
{
    public class ShowHouseLockPacket : AbstractPacket
    {
        public ShowHouseLockPacket() : base(new Packet("SHOWHOUSELOCK", new string[1])) { }
        public ShowHouseLockPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
