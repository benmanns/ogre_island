using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class SpecBarPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public SpecBarPacketReceivedEventArgs(SpecBarPacket packet) : base(packet) { }
        public new SpecBarPacket Packet { get { return (SpecBarPacket)base.Packet; } }
    }
    public delegate void SpecBarPacketReceivedEventHandler(object sender, SpecBarPacketReceivedEventArgs e);
}
