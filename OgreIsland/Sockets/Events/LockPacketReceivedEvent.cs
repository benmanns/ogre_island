using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class LockPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public LockPacketReceivedEventArgs(LockPacket packet) : base(packet) { }
        public new LockPacket Packet { get { return (LockPacket)base.Packet; } }
    }
    public delegate void LockPacketReceivedEventHandler(object sender, LockPacketReceivedEventArgs e);
}
