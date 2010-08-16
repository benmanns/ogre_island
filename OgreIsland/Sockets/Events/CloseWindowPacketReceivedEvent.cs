using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class CloseWindowPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public CloseWindowPacketReceivedEventArgs(CloseWindowPacket packet) : base(packet) { }
        public new CloseWindowPacket Packet { get { return (CloseWindowPacket)base.Packet; } }
    }
    public delegate void CloseWindowPacketReceivedEventHandler(object sender, CloseWindowPacketReceivedEventArgs e);
}
