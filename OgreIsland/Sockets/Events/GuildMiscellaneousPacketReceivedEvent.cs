using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class GuildMiscellaneousPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public GuildMiscellaneousPacketReceivedEventArgs(GuildMiscellaneousPacket packet) : base(packet) { }
        public new GuildMiscellaneousPacket Packet { get { return (GuildMiscellaneousPacket)base.Packet; } }
    }
    public delegate void GuildMiscellaneousPacketReceivedEventHandler(object sender, GuildMiscellaneousPacketReceivedEventArgs e);
}
