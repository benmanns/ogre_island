using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class SoundTogglePacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public SoundTogglePacketReceivedEventArgs(SoundTogglePacket packet) : base(packet) { }
        public new SoundTogglePacket Packet { get { return (SoundTogglePacket)base.Packet; } }
    }
    public delegate void SoundTogglePacketReceivedEventHandler(object sender, SoundTogglePacketReceivedEventArgs e);
}
