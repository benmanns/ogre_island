using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class TakeFromBagPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public TakeFromBagPacketReceivedEventArgs(TakeFromBagPacket packet) : base(packet) { }
        public new TakeFromBagPacket Packet { get { return (TakeFromBagPacket)base.Packet; } }
    }
    public delegate void TakeFromBagPacketReceivedEventHandler(object sender, TakeFromBagPacketReceivedEventArgs e);
}
