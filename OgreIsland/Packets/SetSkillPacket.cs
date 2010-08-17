namespace OgreIsland.Packets
{
    public class SetSkillPacket : AbstractPacket
    {
        public SetSkillPacket() : base(new Packet("SETSKILL", new string[16])) { }
        public SetSkillPacket(Packet packet) : base(packet) { }
        public string Name { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Value { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Icon2 { get { return Arguments[2]; } set { Arguments[2] = value; } }
        public string Text2 { get { return Arguments[3]; } set { Arguments[3] = value; } }
        public string Icon3 { get { return Arguments[4]; } set { Arguments[4] = value; } }
        public string Text3 { get { return Arguments[5]; } set { Arguments[5] = value; } }
        public string Icon4 { get { return Arguments[6]; } set { Arguments[6] = value; } }
        public string Text4 { get { return Arguments[7]; } set { Arguments[7] = value; } }
        public string Icon5 { get { return Arguments[8]; } set { Arguments[8] = value; } }
        public string Text5 { get { return Arguments[9]; } set { Arguments[9] = value; } }
        public string Icon6 { get { return Arguments[10]; } set { Arguments[10] = value; } }
        public string Text6 { get { return Arguments[11]; } set { Arguments[11] = value; } }
        public string Icon7 { get { return Arguments[12]; } set { Arguments[12] = value; } }
        public string Text7 { get { return Arguments[13]; } set { Arguments[13] = value; } }
        public string Icon8 { get { return Arguments[14]; } set { Arguments[14] = value; } }
        public string Text8 { get { return Arguments[15]; } set { Arguments[15] = value; } }
    }
}
