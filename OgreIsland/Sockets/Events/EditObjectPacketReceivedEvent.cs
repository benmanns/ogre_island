using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class EditObjectPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public EditObjectPacketReceivedEventArgs(EditObjectPacket packet) : base(packet) { }
        public new EditObjectPacket Packet { get { return (EditObjectPacket)base.Packet; } }
    }
    public delegate void EditObjectPacketReceivedEventHandler(object sender, EditObjectPacketReceivedEventArgs e);
}
