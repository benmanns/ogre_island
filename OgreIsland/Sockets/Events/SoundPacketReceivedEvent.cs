using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class SoundPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public SoundPacketReceivedEventArgs(SoundPacket packet) : base(packet) { }
        public new SoundPacket Packet { get { return (SoundPacket)base.Packet; } }
    }
    public delegate void SoundPacketReceivedEventHandler(object sender, SoundPacketReceivedEventArgs e);
}
