namespace OgreIsland.Packets
{
    public class InventoryPacket : AbstractPacket
    {
        public InventoryPacket() : base(new Packet("INV", new string[1])) { }
        public InventoryPacket(Packet packet) : base(packet) { }
        public string Inventorystring { get { return Arguments[0]; } set { Arguments[0] = value; } }
    }
}
