using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class TradeWindowPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public TradeWindowPacketReceivedEventArgs(TradeWindowPacket packet) : base(packet) { }
        public new TradeWindowPacket Packet { get { return (TradeWindowPacket)base.Packet; } }
    }
    public delegate void TradeWindowPacketReceivedEventHandler(object sender, TradeWindowPacketReceivedEventArgs e);
}
