using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class HandshakePacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public HandshakePacketReceivedEventArgs(HandshakePacket packet) : base(packet) { }
        public new HandshakePacket Packet { get { return (HandshakePacket)base.Packet; } }
    }
    public delegate void HandshakePacketReceivedEventHandler(object sender, HandshakePacketReceivedEventArgs e);
}
