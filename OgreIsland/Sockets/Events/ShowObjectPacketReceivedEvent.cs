using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class ShowObjectPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public ShowObjectPacketReceivedEventArgs(ShowObjectPacket packet) : base(packet) { }
        public new ShowObjectPacket Packet { get { return (ShowObjectPacket)base.Packet; } }
    }
    public delegate void ShowObjectPacketReceivedEventHandler(object sender, ShowObjectPacketReceivedEventArgs e);
}
