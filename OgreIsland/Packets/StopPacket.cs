namespace OgreIsland.Packets
{
    public class StopPacket : AbstractPacket
    {
        public StopPacket() : base(new Packet("STOP", new string[1])) { }
        public StopPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
