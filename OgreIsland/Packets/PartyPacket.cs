namespace OgreIsland.Packets
{
    public class PartyPacket : AbstractPacket
    {
        public PartyPacket() : base(new Packet("PARTY", new string[1])) { }
        public PartyPacket(Packet packet) : base(packet) { }
        public string Partystring { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
