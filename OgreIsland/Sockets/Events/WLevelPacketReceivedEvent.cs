using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class WLevelPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public WLevelPacketReceivedEventArgs(WLevelPacket packet) : base(packet) { }
        public new WLevelPacket Packet { get { return (WLevelPacket)base.Packet; } }
    }
    public delegate void WLevelPacketReceivedEventHandler(object sender, WLevelPacketReceivedEventArgs e);
}
