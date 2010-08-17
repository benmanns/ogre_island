using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class PlayPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public PlayPacketReceivedEventArgs(PlayPacket packet) : base(packet) { }
        public new PlayPacket Packet { get { return (PlayPacket)base.Packet; } }
    }
    public delegate void PlayPacketReceivedEventHandler(object sender, PlayPacketReceivedEventArgs e);
}
