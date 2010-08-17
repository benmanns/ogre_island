using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class InventoryPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public InventoryPacketReceivedEventArgs(InventoryPacket packet) : base(packet) { }
        public new InventoryPacket Packet { get { return (InventoryPacket)base.Packet; } }
    }
    public delegate void InventoryPacketReceivedEventHandler(object sender, InventoryPacketReceivedEventArgs e);
}
