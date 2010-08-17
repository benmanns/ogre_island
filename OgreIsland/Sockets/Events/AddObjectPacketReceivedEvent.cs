using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class AddObjectPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public AddObjectPacketReceivedEventArgs(AddObjectPacket packet) : base(packet) { }
        public new AddObjectPacket Packet { get { return (AddObjectPacket) base.Packet; } }
    }
    public delegate void AddObjectPacketReceivedEventHandler(object sender, AddObjectPacketReceivedEventArgs e);
}
