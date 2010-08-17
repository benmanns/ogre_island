namespace OgreIsland.Packets
{
    public class ChatChannelPacket : AbstractPacket
    {
        public ChatChannelPacket() : base(new Packet("CCHANNEL", new string[1])) { }
        public ChatChannelPacket(Packet packet) : base(packet) { }
        public string Channel { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
