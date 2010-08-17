using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class PartyPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public PartyPacketReceivedEventArgs(PartyPacket packet) : base(packet) { }
        public new PartyPacket Packet { get { return (PartyPacket)base.Packet; } }
    }
    public delegate void PartyPacketReceivedEventHandler(object sender, PartyPacketReceivedEventArgs e);
}
