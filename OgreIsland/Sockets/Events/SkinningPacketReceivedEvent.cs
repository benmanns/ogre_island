using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class SkinningPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public SkinningPacketReceivedEventArgs(SkinningPacket packet) : base(packet) { }
        public new SkinningPacket Packet { get { return (SkinningPacket)base.Packet; } }
    }
    public delegate void SkinningPacketReceivedEventHandler(object sender, SkinningPacketReceivedEventArgs e);
}
