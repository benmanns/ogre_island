namespace OgreIsland.Packets
{
    public class ModifyBagItemPacket : AbstractPacket
    {
        public ModifyBagItemPacket() : base(new Packet("MODIFYBAGITEM", new string[2])) { }
        public ModifyBagItemPacket(Packet packet) : base(packet) { }
        public string Bag { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Contents { get { return Arguments[1]; } set { Arguments[1] = value; } }
    }
}
