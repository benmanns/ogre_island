using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class MoveObjectOtherPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public MoveObjectOtherPacketReceivedEventArgs(MoveObjectOtherPacket packet) : base(packet) { }
        public new MoveObjectOtherPacket Packet { get { return (MoveObjectOtherPacket)base.Packet; } }
    }
    public delegate void MoveObjectOtherPacketReceivedEventHandler(object sender, MoveObjectOtherPacketReceivedEventArgs e);
}
