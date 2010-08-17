using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class SayPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public SayPacketReceivedEventArgs(SayPacket packet) : base(packet) { }
        public new SayPacket Packet { get { return (SayPacket)base.Packet; } }
    }
    public delegate void SayPacketReceivedEventHandler(object sender, SayPacketReceivedEventArgs e);
}
