using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class SpellBarTextLeftPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public SpellBarTextLeftPacketReceivedEventArgs(SpellBarTextLeftPacket packet) : base(packet) { }
        public new SpellBarTextLeftPacket Packet { get { return (SpellBarTextLeftPacket)base.Packet; } }
    }
    public delegate void SpellBarTextLeftPacketReceivedEventHandler(object sender, SpellBarTextLeftPacketReceivedEventArgs e);
}
