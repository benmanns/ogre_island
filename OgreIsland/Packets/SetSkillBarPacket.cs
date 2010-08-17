namespace OgreIsland.Packets
{
    public class SetSkillBarPacket : AbstractPacket
    {
        public SetSkillBarPacket() : base(new Packet("SETSKILLBAR", new string[1])) { }
        public SetSkillBarPacket(Packet packet) : base(packet) { }
        public string Itemstring { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
