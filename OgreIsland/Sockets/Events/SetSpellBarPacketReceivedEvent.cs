using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class SetSpellBarPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public SetSpellBarPacketReceivedEventArgs(SetSpellBarPacket packet) : base(packet) { }
        public new SetSpellBarPacket Packet { get { return (SetSpellBarPacket)base.Packet; } }
    }
    public delegate void SetSpellBarPacketReceivedEventHandler(object sender, SetSpellBarPacketReceivedEventArgs e);
}
