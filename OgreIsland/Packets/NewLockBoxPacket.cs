namespace OgreIsland.Packets
{
    public class NewLockBoxPacket : AbstractPacket
    {
        public NewLockBoxPacket() : base(new Packet("NEWLOCKBOX", new string[1])) { }
        public NewLockBoxPacket(Packet packet) : base(packet) { }
        public string Frame { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
