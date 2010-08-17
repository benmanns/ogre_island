namespace OgreIsland.Packets
{
    public class RemoveObjectPacket : AbstractPacket
    {
        public RemoveObjectPacket() : base(new Packet("REMOBJ", new string[1])) { }
        public RemoveObjectPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
