namespace OgreIsland.Packets
{
    public class RemoveCharacterPacket : AbstractPacket
    {
        public RemoveCharacterPacket() : base(new Packet("REMCHAR", new string[1])) { }
        public RemoveCharacterPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
