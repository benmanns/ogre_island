using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class JoinPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public JoinPacketReceivedEventArgs(JoinPacket packet) : base(packet) { }
        public new JoinPacket Packet { get { return (JoinPacket)base.Packet; } }
    }
    public delegate void JoinPacketReceivedEventHandler(object sender, JoinPacketReceivedEventArgs e);
}
