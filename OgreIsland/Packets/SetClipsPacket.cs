namespace OgreIsland.Packets
{
    public class SetClipsPacket : AbstractPacket
    {
        public SetClipsPacket() : base(new Packet("SETCLIPS", new string[25])) { }
        public SetClipsPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string XScale { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string YScale { get { return Arguments[2]; } set { Arguments[2] = value; } }
        public string Alpha { get { return Arguments[3]; } set { Arguments[3] = value; } }
        public string Mount { get { return Arguments[4]; } set { Arguments[4] = value; } }
        public string Head { get { return Arguments[5]; } set { Arguments[5] = value; } }
        public string HeadGear { get { return Arguments[6]; } set { Arguments[6] = value; } }
        public string Hair { get { return Arguments[7]; } set { Arguments[7] = value; } }
        public string FaceHair { get { return Arguments[8]; } set { Arguments[8] = value; } }
        public string Torso { get { return Arguments[9]; } set { Arguments[9] = value; } }
        public string RightArm { get { return Arguments[10]; } set { Arguments[10] = value; } }
        public string LeftArm { get { return Arguments[11]; } set { Arguments[11] = value; } }
        public string RightLeg { get { return Arguments[12]; } set { Arguments[12] = value; } }
        public string LeftLeg { get { return Arguments[13]; } set { Arguments[13] = value; } }
        public string RightFoot { get { return Arguments[14]; } set { Arguments[14] = value; } }
        public string LeftFoot { get { return Arguments[15]; } set { Arguments[15] = value; } }
        public string LeftObject { get { return Arguments[16]; } set { Arguments[16] = value; } }
        public string RightObject { get { return Arguments[17]; } set { Arguments[17] = value; } }
        public string ShirtColor { get { return Arguments[18]; } set { Arguments[18] = value; } }
        public string PantsColor { get { return Arguments[19]; } set { Arguments[19] = value; } }
        public string LeftObjectEffect { get { return Arguments[20]; } set { Arguments[20] = value; } }
        public string RightObjectEffect { get { return Arguments[21]; } set { Arguments[21] = value; } }
        public string Cloak { get { return Arguments[22]; } set { Arguments[22] = value; } }
        public string SpellEffect { get { return Arguments[23]; } set { Arguments[23] = value; } }
        public string IconColor { get { return Arguments[24]; } set { Arguments[24] = value; } }
    }
}
