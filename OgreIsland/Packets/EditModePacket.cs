namespace OgreIsland.Packets
{
    public class EditModePacket : AbstractPacket
    {
        public EditModePacket() : base(new Packet("EDITMODE", null)) { }
        public EditModePacket(Packet packet) : base(packet) { }
    }
}
