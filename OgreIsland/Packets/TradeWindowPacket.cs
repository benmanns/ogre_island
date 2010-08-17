namespace OgreIsland.Packets
{
    public class TradeWindowPacket : AbstractPacket
    {
        public TradeWindowPacket() : base(new Packet("TRADEWINDOW", new string[1])) { }
        public TradeWindowPacket(Packet packet) : base(packet) { }
        public string Frame { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
