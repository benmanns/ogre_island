namespace OgreIsland.Packets
{
    public class ActionPacket : AbstractPacket
    {
        public ActionPacket() : base(new Packet("ACTION", new string[3])) { }
        public ActionPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Action { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Direction { get { return Arguments[2]; } set { Arguments[2] = value; } }
    }
}
