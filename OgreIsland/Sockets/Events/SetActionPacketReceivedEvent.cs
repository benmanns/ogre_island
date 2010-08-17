using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class SetActionPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public SetActionPacketReceivedEventArgs(SetActionPacket packet) : base(packet) { }
        public new SetActionPacket Packet { get { return (SetActionPacket)base.Packet; } }
    }
    public delegate void SetActionPacketReceivedEventHandler(object sender, SetActionPacketReceivedEventArgs e);
}
