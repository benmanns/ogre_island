namespace OgreIsland.Packets
{
    public class MoveObjectPacket : AbstractPacket
    {
        public MoveObjectPacket() : base(new Packet("MOVEOBJ", new string[4])) { }
        public MoveObjectPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string X { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Y { get { return Arguments[2]; } set { Arguments[2] = value; } }
        public string Z { get { return Arguments[3]; } set { Arguments[3] = value; } }
    }
}
