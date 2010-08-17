using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class HealthBarPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public HealthBarPacketReceivedEventArgs(HealthBarPacket packet) : base(packet) { }
        public new HealthBarPacket Packet { get { return (HealthBarPacket)base.Packet; } }
    }
    public delegate void HealthBarPacketReceivedEventHandler(object sender, HealthBarPacketReceivedEventArgs e);
}
