namespace OgreIsland.Packets
{
    public class ToolIconPacket : AbstractPacket
    {
        public ToolIconPacket() : base(new Packet("TOOLICON", new string[1])) { }
        public ToolIconPacket(Packet packet) : base(packet) { }
        public string Frame { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
