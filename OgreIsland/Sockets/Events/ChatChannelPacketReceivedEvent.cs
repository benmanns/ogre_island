using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class ChatChannelPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public ChatChannelPacketReceivedEventArgs(ChatChannelPacket packet) : base(packet) { }
        public new ChatChannelPacket Packet { get { return (ChatChannelPacket)base.Packet; } }
    }
    public delegate void ChatChannelPacketReceivedEventHandler(object sender, ChatChannelPacketReceivedEventArgs e);
}
