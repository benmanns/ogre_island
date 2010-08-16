namespace OgreIsland.Packets
{
    public class AttackPacket : AbstractPacket
    {
        public AttackPacket() : base(new Packet("ATTACK", new string[4])) { }
        public AttackPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string X { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Y { get { return Arguments[2]; } set { Arguments[2] = value; } }
        public string Direction { get { return Arguments[3]; } set { Arguments[3] = value; } }
    }
}
