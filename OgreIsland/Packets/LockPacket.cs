namespace OgreIsland.Packets
{
    public class LockPacket : AbstractPacket
    {
        public LockPacket() : base(new Packet("LOCK", new string[2])) { }
        public LockPacket(Packet packet) : base(packet) { }
        public string MC { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Frame { get { return Arguments[1]; } set { Arguments[1] = value; } }
    }
}
