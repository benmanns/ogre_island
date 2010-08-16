using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class BattleTextMiscellaneousPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public BattleTextMiscellaneousPacketReceivedEventArgs(BattleTextMiscellaneousPacket packet) : base(packet) { }
        public new BattleTextMiscellaneousPacket Packet { get { return (BattleTextMiscellaneousPacket)base.Packet; } }
    }
    public delegate void BattleTextMiscellaneousPacketReceivedEventHandler(object sender, BattleTextMiscellaneousPacketReceivedEventArgs e);
}
