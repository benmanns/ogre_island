using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class SelectedPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public SelectedPacketReceivedEventArgs(SelectedPacket packet) : base(packet) { }
        public new SelectedPacket Packet { get { return (SelectedPacket)base.Packet; } }
    }
    public delegate void SelectedPacketReceivedEventHandler(object sender, SelectedPacketReceivedEventArgs e);
}
