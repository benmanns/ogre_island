using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class ActionPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public ActionPacketReceivedEventArgs(ActionPacket packet) : base(packet) { }
        public new ActionPacket Packet { get { return (ActionPacket)base.Packet; } }
    }
    public delegate void ActionPacketReceivedEventHandler(object sender, ActionPacketReceivedEventArgs e);
}