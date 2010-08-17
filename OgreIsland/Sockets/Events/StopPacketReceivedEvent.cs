using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class StopPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public StopPacketReceivedEventArgs(StopPacket packet) : base(packet) { }
        public new StopPacket Packet { get { return (StopPacket)base.Packet; } }
    }
    public delegate void StopPacketReceivedEventHandler(object sender, StopPacketReceivedEventArgs e);
}
