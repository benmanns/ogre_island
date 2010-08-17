using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class HideObjectPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public HideObjectPacketReceivedEventArgs(HideObjectPacket packet) : base(packet) { }
        public new HideObjectPacket Packet { get { return (HideObjectPacket)base.Packet; } }
    }
    public delegate void HideObjectPacketReceivedEventHandler(object sender, HideObjectPacketReceivedEventArgs e);
}
