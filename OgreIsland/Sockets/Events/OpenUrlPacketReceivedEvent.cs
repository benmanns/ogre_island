using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class OpenUrlPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public OpenUrlPacketReceivedEventArgs(OpenUrlPacket packet) : base(packet) { }
        public new OpenUrlPacket Packet { get { return (OpenUrlPacket)base.Packet; } }
    }
    public delegate void OpenUrlPacketReceivedEventHandler(object sender, OpenUrlPacketReceivedEventArgs e);
}
