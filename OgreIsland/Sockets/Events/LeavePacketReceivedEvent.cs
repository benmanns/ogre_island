using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class LeavePacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public LeavePacketReceivedEventArgs(LeavePacket packet) : base(packet) { }
        public new LeavePacket Packet { get { return (LeavePacket)base.Packet; } }
    }
    public delegate void LeavePacketReceivedEventHandler(object sender, LeavePacketReceivedEventArgs e);
}
