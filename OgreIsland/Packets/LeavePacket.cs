namespace OgreIsland.Packets
{
    public class LeavePacket : AbstractPacket
    {
        public LeavePacket() : base(new Packet("LEAVE", new string[1])) { }
        public LeavePacket(Packet packet) : base(packet) { }
        public string Name { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
