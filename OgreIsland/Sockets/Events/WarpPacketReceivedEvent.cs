using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class WarpPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public WarpPacketReceivedEventArgs(WarpPacket packet) : base(packet) { }
        public new WarpPacket Packet { get { return (WarpPacket)base.Packet; } }
    }
    public delegate void WarpPacketReceivedEventHandler(object sender, WarpPacketReceivedEventArgs e);
}
