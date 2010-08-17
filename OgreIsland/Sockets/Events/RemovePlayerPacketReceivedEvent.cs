using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class RemovePlayerPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public RemovePlayerPacketReceivedEventArgs(RemovePlayerPacket packet) : base(packet) { }
        public new RemovePlayerPacket Packet { get { return (RemovePlayerPacket)base.Packet; } }
    }
    public delegate void RemovePlayerPacketReceivedEventHandler(object sender, RemovePlayerPacketReceivedEventArgs e);
}
