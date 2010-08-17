namespace OgreIsland.Packets
{
    public class SetActionPacket : AbstractPacket
    {
        public SetActionPacket() : base(new Packet("SETACTION", new string[3])) { }
        public SetActionPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Name { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Frame { get { return Arguments[2]; } set { Arguments[2] = value; } }
    }
}
