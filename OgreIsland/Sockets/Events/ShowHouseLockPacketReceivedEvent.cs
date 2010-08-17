using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class ShowHouseLockPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public ShowHouseLockPacketReceivedEventArgs(ShowHouseLockPacket packet) : base(packet) { }
        public new ShowHouseLockPacket Packet { get { return (ShowHouseLockPacket)base.Packet; } }
    }
    public delegate void ShowHouseLockPacketReceivedEventHandler(object sender, ShowHouseLockPacketReceivedEventArgs e);
}
