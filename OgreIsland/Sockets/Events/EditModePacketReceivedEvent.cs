using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class EditModePacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public EditModePacketReceivedEventArgs(EditModePacket packet) : base(packet) { }
        public new EditModePacket Packet { get { return (EditModePacket)base.Packet; } }
    }
    public delegate void EditModePacketReceivedEventHandler(object sender, EditModePacketReceivedEventArgs e);
}
