using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class AddToBagPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public AddToBagPacketReceivedEventArgs(AddToBagPacket packet) : base(packet) { }
        public new AddToBagPacket Packet { get { return (AddToBagPacket)base.Packet; } }
    }
    public delegate void AddToBagPacketReceivedEventHandler(object sender, AddToBagPacketReceivedEventArgs e);
}
