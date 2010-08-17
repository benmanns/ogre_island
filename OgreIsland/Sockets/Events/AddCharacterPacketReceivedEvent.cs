using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class AddCharacterPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public AddCharacterPacketReceivedEventArgs(AddCharacterPacket packet) : base(packet) { }
        public new AddCharacterPacket Packet { get { return (AddCharacterPacket) base.Packet; } }
    }
    public delegate void AddCharacterPacketReceivedEventHandler(object sender, AddCharacterPacketReceivedEventArgs e);
}