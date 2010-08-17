using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class SetTextPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public SetTextPacketReceivedEventArgs(SetTextPacket packet) : base(packet) { }
        public new SetTextPacket Packet { get { return (SetTextPacket)base.Packet; } }
    }
    public delegate void SetTextPacketReceivedEventHandler(object sender, SetTextPacketReceivedEventArgs e);
}
