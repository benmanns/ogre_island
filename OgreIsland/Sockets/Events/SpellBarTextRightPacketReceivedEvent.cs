using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class SpellBarTextRightPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public SpellBarTextRightPacketReceivedEventArgs(SpellBarTextRightPacket packet) : base(packet) { }
        public new SpellBarTextRightPacket Packet { get { return (SpellBarTextRightPacket)base.Packet; } }
    }
    public delegate void SpellBarTextRightPacketReceivedEventHandler(object sender, SpellBarTextRightPacketReceivedEventArgs e);
}
