using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class MessageBoxPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public MessageBoxPacketReceivedEventArgs(MessageBoxPacket packet) : base(packet) { }
        public new MessageBoxPacket Packet { get { return (MessageBoxPacket)base.Packet; } }
    }
    public delegate void MessageBoxPacketReceivedEventHandler(object sender, MessageBoxPacketReceivedEventArgs e);
}
