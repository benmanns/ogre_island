using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class DebugPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public DebugPacketReceivedEventArgs(DebugPacket packet) : base(packet) { }
        public new DebugPacket Packet { get { return (DebugPacket)base.Packet; } }
    }
    public delegate void DebugPacketReceivedEventHandler(object sender, DebugPacketReceivedEventArgs e);
}
