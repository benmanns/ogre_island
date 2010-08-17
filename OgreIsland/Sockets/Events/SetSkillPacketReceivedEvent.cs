using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class SetSkillPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public SetSkillPacketReceivedEventArgs(SetSkillPacket packet) : base(packet) { }
        public new SetSkillPacket Packet { get { return (SetSkillPacket)base.Packet; } }
    }
    public delegate void SetSkillPacketReceivedEventHandler(object sender, SetSkillPacketReceivedEventArgs e);
}
