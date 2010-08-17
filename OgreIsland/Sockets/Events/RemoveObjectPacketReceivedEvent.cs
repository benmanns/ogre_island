using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class RemoveObjectPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public RemoveObjectPacketReceivedEventArgs(RemoveObjectPacket packet) : base(packet) { }
        public new RemoveObjectPacket Packet { get { return (RemoveObjectPacket)base.Packet; } }
    }
    public delegate void RemoveObjectPacketReceivedEventHandler(object sender, RemoveObjectPacketReceivedEventArgs e);
}
