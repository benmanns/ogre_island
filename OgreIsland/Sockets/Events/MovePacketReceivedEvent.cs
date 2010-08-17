using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class MovePacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public MovePacketReceivedEventArgs(MovePacket packet) : base(packet) { }
        public new MovePacket Packet { get { return (MovePacket)base.Packet; } }
    }
    public delegate void MovePacketReceivedEventHandler(object sender, MovePacketReceivedEventArgs e);
}
