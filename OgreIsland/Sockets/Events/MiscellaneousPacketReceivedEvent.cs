using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class MiscellaneousPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public MiscellaneousPacketReceivedEventArgs(MiscellaneousPacket packet) : base(packet) { }
        public new MiscellaneousPacket Packet { get { return (MiscellaneousPacket)base.Packet; } }
    }
    public delegate void MiscellaneousPacketReceivedEventHandler(object sender, MiscellaneousPacketReceivedEventArgs e);
}
