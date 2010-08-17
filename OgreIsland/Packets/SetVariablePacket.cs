namespace OgreIsland.Packets
{
    public class SetVariablePacket : AbstractPacket
    {
        public SetVariablePacket() : base(new Packet("SV", new string[2])) { }
        public SetVariablePacket(Packet packet) : base(packet) { }
        public string Evaluation { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Value { get { return Arguments[1]; } set { Arguments[1] = value; } }
    }
}
