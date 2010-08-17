using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class TickPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public TickPacketReceivedEventArgs(TickPacket packet) : base(packet) { }
        public new TickPacket Packet { get { return (TickPacket)base.Packet; } }
    }
    public delegate void TickPacketReceivedEventHandler(object sender, TickPacketReceivedEventArgs e);
}
