using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class SetVariablePacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public SetVariablePacketReceivedEventArgs(SetVariablePacket packet) : base(packet) { }
        public new SetVariablePacket Packet { get { return (SetVariablePacket)base.Packet; } }
    }
    public delegate void SetVariablePacketReceivedEventHandler(object sender, SetVariablePacketReceivedEventArgs e);
}
