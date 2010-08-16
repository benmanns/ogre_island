using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class AttackPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public AttackPacketReceivedEventArgs(AttackPacket packet) : base(packet) { }
        public new AttackPacket Packet { get { return (AttackPacket)base.Packet; } }
    }
    public delegate void AttackPacketReceivedEventHandler(object sender, AttackPacketReceivedEventArgs e);
}
