using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class OpenWindowPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public OpenWindowPacketReceivedEventArgs(OpenWindowPacket packet) : base(packet) { }
        public new OpenWindowPacket Packet { get { return (OpenWindowPacket)base.Packet; } }
    }
    public delegate void OpenWindowPacketReceivedEventHandler(object sender, OpenWindowPacketReceivedEventArgs e);
}
