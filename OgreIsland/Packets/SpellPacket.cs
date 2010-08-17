namespace OgreIsland.Packets
{
    public class SpellPacket : AbstractPacket
    {
        public SpellPacket() : base(new Packet("SPELL", new string[15])) { }
        public SpellPacket(Packet packet) : base(packet) { }
        public string Frame { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Time { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string X { get { return Arguments[2]; } set { Arguments[2] = value; } }
        public string Y { get { return Arguments[3]; } set { Arguments[3] = value; } }
        public string Z { get { return Arguments[4]; } set { Arguments[4] = value; } }
        public string MoveX { get { return Arguments[5]; } set { Arguments[5] = value; } }
        public string MoveY { get { return Arguments[6]; } set { Arguments[6] = value; } }
        public string Speed { get { return Arguments[7]; } set { Arguments[7] = value; } }
        public string Delay { get { return Arguments[8]; } set { Arguments[8] = value; } }
        public string XScale { get { return Arguments[9]; } set { Arguments[9] = value; } }
        public string YScale { get { return Arguments[10]; } set { Arguments[10] = value; } }
        public string FinalFrame { get { return Arguments[11]; } set { Arguments[11] = value; } }
        public string FinalDelay { get { return Arguments[12]; } set { Arguments[12] = value; } }
        public string FinalXScale { get { return Arguments[13]; } set { Arguments[13] = value; } }
        public string FinalYScale { get { return Arguments[14]; } set { Arguments[14] = value; } }
    }
}
