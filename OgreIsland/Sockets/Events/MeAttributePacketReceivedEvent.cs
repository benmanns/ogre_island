using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class MeAttributePacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public MeAttributePacketReceivedEventArgs(MeAttributePacket packet) : base(packet) { }
        public new MeAttributePacket Packet { get { return (MeAttributePacket)base.Packet; } }
    }
    public delegate void MeAttributePacketReceivedEventHandler(object sender, MeAttributePacketReceivedEventArgs e);
}
