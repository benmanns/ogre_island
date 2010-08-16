using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class FocusPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public FocusPacketReceivedEventArgs(FocusPacket packet) : base(packet) { }
        public new FocusPacket Packet { get { return (FocusPacket)base.Packet; } }
    }
    public delegate void FocusPacketReceivedEventHandler(object sender, FocusPacketReceivedEventArgs e);
}
