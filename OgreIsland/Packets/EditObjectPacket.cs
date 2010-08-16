namespace OgreIsland.Packets
{
    public class EditObjectPacket : AbstractPacket
    {
        public EditObjectPacket() : base(new Packet("EDITOBJECT", new string[17])) { }
        public EditObjectPacket(Packet packet) : base(packet) { }
        public string Id { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Owner { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Clip { get { return Arguments[2]; } set { Arguments[2] = value; } }
        public string SessionGroup { get { return Arguments[3]; } set { Arguments[3] = value; } }
        public string EditGroup { get { return Arguments[4]; } set { Arguments[4] = value; } }
        public string Type { get { return Arguments[5]; } set { Arguments[5] = value; } }
        public string Link { get { return Arguments[6]; } set { Arguments[6] = value; } }
        public string SortDepth { get { return Arguments[7]; } set { Arguments[7] = value; } }
        public string Frame { get { return Arguments[8]; } set { Arguments[8] = value; } }
        public string X { get { return Arguments[9]; } set { Arguments[9] = value; } }
        public string Y { get { return Arguments[10]; } set { Arguments[10] = value; } }
        public string Z { get { return Arguments[11]; } set { Arguments[11] = value; } }
        public string XScale { get { return Arguments[12]; } set { Arguments[12] = value; } }
        public string YScale { get { return Arguments[13]; } set { Arguments[13] = value; } }
        public string Attributes { get { return Arguments[14]; } set { Arguments[14] = value; } }
        public string Subclips { get { return Arguments[15]; } set { Arguments[15] = value; } }
        public string WLevel { get { return Arguments[16]; } set { Arguments[16] = value; } }
    }
}
