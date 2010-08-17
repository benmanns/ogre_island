using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class NoFloodWarningPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public NoFloodWarningPacketReceivedEventArgs(NoFloodWarningPacket packet) : base(packet) { }
        public new NoFloodWarningPacket Packet { get { return (NoFloodWarningPacket)base.Packet; } }
    }
    public delegate void NoFloodWarningPacketReceivedEventHandler(object sender, NoFloodWarningPacketReceivedEventArgs e);
}
