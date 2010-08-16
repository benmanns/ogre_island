using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class CloseLootPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public CloseLootPacketReceivedEventArgs(CloseLootPacket packet) : base(packet) { }
        public new CloseLootPacket Packet { get { return (CloseLootPacket)base.Packet; } }
    }
    public delegate void CloseLootPacketReceivedEventHandler(object sender, CloseLootPacketReceivedEventArgs e);
}
