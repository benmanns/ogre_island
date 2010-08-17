using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class CharacterAttributePacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public CharacterAttributePacketReceivedEventArgs(CharacterAttributePacket packet) : base(packet) { }
        public new CharacterAttributePacket Packet { get { return (CharacterAttributePacket)base.Packet; } }
    }
    public delegate void CharacterAttributePacketReceivedEventHandler(object sender, CharacterAttributePacketReceivedEventArgs e);
}
