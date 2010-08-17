using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class HouseItemTabPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public HouseItemTabPacketReceivedEventArgs(HouseItemTabPacket packet) : base(packet) { }
        public new HouseItemTabPacket Packet { get { return (HouseItemTabPacket)base.Packet; } }
    }
    public delegate void HouseItemTabPacketReceivedEventHandler(object sender, HouseItemTabPacketReceivedEventArgs e);
}
