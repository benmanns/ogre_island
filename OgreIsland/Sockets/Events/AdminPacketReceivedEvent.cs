using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class AdminPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public AdminPacketReceivedEventArgs(AdminPacket packet) : base(packet) { }
        public new AdminPacket Packet { get { return (AdminPacket)base.Packet; } }
    }
    public delegate void AdminPacketReceivedEventHandler(object sender, AdminPacketReceivedEventArgs e);
}
