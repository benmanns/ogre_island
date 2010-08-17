namespace OgreIsland.Packets
{
    public class LoadPanelPacket : AbstractPacket
    {
        public LoadPanelPacket() : base(new Packet("LOADPANEL", new string[2])) { }
        public LoadPanelPacket(Packet packet) : base(packet) { }
        public string Panel { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Uri { get { return Arguments[1]; } set { Arguments[1] = value; } }
    }
}
