using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class ToolIconPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public ToolIconPacketReceivedEventArgs(ToolIconPacket packet) : base(packet) { }
        public new ToolIconPacket Packet { get { return (ToolIconPacket)base.Packet; } }
    }
    public delegate void ToolIconPacketReceivedEventHandler(object sender, ToolIconPacketReceivedEventArgs e);
}
