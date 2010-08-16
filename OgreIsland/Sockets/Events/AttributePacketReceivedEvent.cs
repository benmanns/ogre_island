using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class AttributePacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public AttributePacketReceivedEventArgs(AttributePacket packet) : base(packet) { }
        public new AttributePacket Packet { get { return (AttributePacket)base.Packet; } }
    }
    public delegate void AttributePacketReceivedEventHandler(object sender, AttributePacketReceivedEventArgs e);
}
