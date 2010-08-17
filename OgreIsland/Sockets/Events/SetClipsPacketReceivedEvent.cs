using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class SetClipsPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public SetClipsPacketReceivedEventArgs(SetClipsPacket packet) : base(packet) { }
        public new SetClipsPacket Packet { get { return (SetClipsPacket)base.Packet; } }
    }
    public delegate void SetClipsPacketReceivedEventHandler(object sender, SetClipsPacketReceivedEventArgs e);
}
