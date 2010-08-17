namespace OgreIsland.Packets
{
    public class PlayerMenuPacket : AbstractPacket
    {
        public PlayerMenuPacket() : base(new Packet("PLAYERMENU", new string[3])) { }
        public PlayerMenuPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Action { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Question { get { return Arguments[2]; } set { Arguments[2] = value; } }
    }
}
