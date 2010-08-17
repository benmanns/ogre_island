namespace OgreIsland.Packets
{
    public class GetVariablePacket : AbstractPacket
    {
        public GetVariablePacket() : base(new Packet("GV", new string[2])) { }
        public GetVariablePacket(Packet packet) : base(packet) { }
        public string ResponseVariable { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Evaluation { get { return Arguments[1]; } set { Arguments[1] = value; } }
    }
}
