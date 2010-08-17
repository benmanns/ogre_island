using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class ClearSpellPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public ClearSpellPacketReceivedEventArgs(ClearSpellPacket packet) : base(packet) { }
        public new ClearSpellPacket Packet { get { return (ClearSpellPacket)base.Packet; } }
    }
    public delegate void ClearSpellPacketReceivedEventHandler(object sender, ClearSpellPacketReceivedEventArgs e);
}
