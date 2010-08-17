using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class SpellPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public SpellPacketReceivedEventArgs(SpellPacket packet) : base(packet) { }
        public new SpellPacket Packet { get { return (SpellPacket)base.Packet; } }
    }
    public delegate void SpellPacketReceivedEventHandler(object sender, SpellPacketReceivedEventArgs e);
}
