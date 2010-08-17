namespace OgreIsland.Packets
{
    public class OpenPanelPacket : AbstractPacket
    {
        public OpenPanelPacket() : base(new Packet("OPENPANEL", new string[2])) { }
        public OpenPanelPacket(Packet packet) : base(packet) { }
        public string Panel { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Frame { get { return Arguments[1]; } set { Arguments[1] = value; } }
    }
}
