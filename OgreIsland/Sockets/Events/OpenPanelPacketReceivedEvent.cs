using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class OpenPanelPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public OpenPanelPacketReceivedEventArgs(OpenPanelPacket packet) : base(packet) { }
        public new OpenPanelPacket Packet { get { return (OpenPanelPacket)base.Packet; } }
    }
    public delegate void OpenPanelPacketReceivedEventHandler(object sender, OpenPanelPacketReceivedEventArgs e);
}
