using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class AddPlayerPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public AddPlayerPacketReceivedEventArgs(AddPlayerPacket packet) : base(packet) { }
        public new AddPlayerPacket Packet { get { return (AddPlayerPacket)base.Packet; } }
    }
    public delegate void AddPlayerPacketReceivedEventHandler(object sender, AddPlayerPacketReceivedEventArgs e);
}
