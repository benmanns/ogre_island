using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class LoginReplyPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public LoginReplyPacketReceivedEventArgs(LoginReplyPacket packet) : base(packet) { }
        public new LoginReplyPacket Packet { get { return (LoginReplyPacket)base.Packet; } }
    }
    public delegate void LoginReplyPacketReceivedEventHandler(object sender, LoginReplyPacketReceivedEventArgs e);
}
