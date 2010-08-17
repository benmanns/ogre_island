using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class RemoveCharacterPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public RemoveCharacterPacketReceivedEventArgs(RemoveCharacterPacket packet) : base(packet) { }
        public new RemoveCharacterPacket Packet { get { return (RemoveCharacterPacket)base.Packet; } }
    }
    public delegate void RemoveCharacterPacketReceivedEventHandler(object sender, RemoveCharacterPacketReceivedEventArgs e);
}
