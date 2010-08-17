using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class GoodbyePacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public GoodbyePacketReceivedEventArgs(GoodbyePacket packet) : base(packet) { }
        public new GoodbyePacket Packet { get { return (GoodbyePacket)base.Packet; } }
    }
    public delegate void GoodbyePacketReceivedEventHandler(object sender, GoodbyePacketReceivedEventArgs e);
}
