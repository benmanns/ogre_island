namespace OgreIsland.Packets
{
    public class ModifyObjectPacket : AbstractPacket
    {
        public ModifyObjectPacket() : base(new Packet("MODOBJ", new string[17])) { }
        public ModifyObjectPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Z { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Frame { get { return Arguments[2]; } set { Arguments[2] = value; } }
        public string XScale { get { return Arguments[3]; } set { Arguments[3] = value; } }
        public string YScale { get { return Arguments[4]; } set { Arguments[4] = value; } }
        public string SortDepth { get { return Arguments[5]; } set { Arguments[5] = value; } }
        public string Alpha { get { return Arguments[6]; } set { Arguments[6] = value; } }
        public string Rotation { get { return Arguments[7]; } set { Arguments[7] = value; } }
        public string Subclips { get { return Arguments[8]; } set { Arguments[8] = value; } }
        public string WLevel { get { return Arguments[9]; } set { Arguments[9] = value; } }
    }
}
