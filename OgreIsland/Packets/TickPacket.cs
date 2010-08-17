namespace OgreIsland.Packets
{
    public class TickPacket : AbstractPacket
    {
        public TickPacket() : base(new Packet("TICK", new string[1])) { }
        public TickPacket(Packet packet) : base(packet) { }
        public string Ticks { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
