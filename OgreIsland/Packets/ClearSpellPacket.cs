namespace OgreIsland.Packets
{
    public class ClearSpellPacket : AbstractPacket
    {
        public ClearSpellPacket() : base(new Packet("CLEARSPELL", new string[1])) { }
        public ClearSpellPacket(Packet packet) : base(packet) { }
        public string Text { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
