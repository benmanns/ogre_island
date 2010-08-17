using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class StatusPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public StatusPacketReceivedEventArgs(StatusPacket packet) : base(packet) { }
        public new StatusPacket Packet { get { return (StatusPacket)base.Packet; } }
    }
    public delegate void StatusPacketReceivedEventHandler(object sender, StatusPacketReceivedEventArgs e);
}
