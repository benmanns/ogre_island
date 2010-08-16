using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class BackgroundColorPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public BackgroundColorPacketReceivedEventArgs(BackgroundColorPacket packet) : base(packet) { }
        public new BackgroundColorPacket Packet { get { return (BackgroundColorPacket)base.Packet; } }
    }
    public delegate void BackgroundColorPacketReceivedEventHandler(object sender, BackgroundColorPacketReceivedEventArgs e);
}
