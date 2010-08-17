using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class GetVariablePacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public GetVariablePacketReceivedEventArgs(GetVariablePacket packet) : base(packet) { }
        public new GetVariablePacket Packet { get { return (GetVariablePacket)base.Packet; } }
    }
    public delegate void GetVariablePacketReceivedEventHandler(object sender, GetVariablePacketReceivedEventArgs e);
}
