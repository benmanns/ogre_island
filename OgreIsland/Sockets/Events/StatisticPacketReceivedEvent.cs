using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class StatisticPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public StatisticPacketReceivedEventArgs(StatisticPacket packet) : base(packet) { }
        public new StatisticPacket Packet { get { return (StatisticPacket)base.Packet; } }
    }
    public delegate void StatisticPacketReceivedEventHandler(object sender, StatisticPacketReceivedEventArgs e);
}
