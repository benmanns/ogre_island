using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class NewLockBoxPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public NewLockBoxPacketReceivedEventArgs(NewLockBoxPacket packet) : base(packet) { }
        public new NewLockBoxPacket Packet { get { return (NewLockBoxPacket)base.Packet; } }
    }
    public delegate void NewLockBoxPacketReceivedEventHandler(object sender, NewLockBoxPacketReceivedEventArgs e);
}
