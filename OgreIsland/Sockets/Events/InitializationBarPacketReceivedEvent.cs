using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class InitializationBarPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public InitializationBarPacketReceivedEventArgs(InitializationBarPacket packet) : base(packet) { }
        public new InitializationBarPacket Packet { get { return (InitializationBarPacket)base.Packet; } }
    }
    public delegate void InitializationBarPacketReceivedEventHandler(object sender, InitializationBarPacketReceivedEventArgs e);
}
