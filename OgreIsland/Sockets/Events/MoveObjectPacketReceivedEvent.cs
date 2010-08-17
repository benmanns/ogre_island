using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class MoveObjectPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public MoveObjectPacketReceivedEventArgs(MoveObjectPacket packet) : base(packet) { }
        public new MoveObjectPacket Packet { get { return (MoveObjectPacket)base.Packet; } }
    }
    public delegate void MoveObjectPacketReceivedEventHandler(object sender, MoveObjectPacketReceivedEventArgs e);
}
