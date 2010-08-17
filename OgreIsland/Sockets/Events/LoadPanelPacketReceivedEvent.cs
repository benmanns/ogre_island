using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class LoadPanelPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public LoadPanelPacketReceivedEventArgs(LoadPanelPacket packet) : base(packet) { }
        public new LoadPanelPacket Packet { get { return (LoadPanelPacket)base.Packet; } }
    }
    public delegate void LoadPanelPacketReceivedEventHandler(object sender, LoadPanelPacketReceivedEventArgs e);
}
