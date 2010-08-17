using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class PlayerMenuPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public PlayerMenuPacketReceivedEventArgs(PlayerMenuPacket packet) : base(packet) { }
        public new PlayerMenuPacket Packet { get { return (PlayerMenuPacket)base.Packet; } }
    }
    public delegate void PlayerMenuPacketReceivedEventHandler(object sender, PlayerMenuPacketReceivedEventArgs e);
}
