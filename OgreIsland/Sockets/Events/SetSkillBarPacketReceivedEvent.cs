using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class SetSkillBarPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public SetSkillBarPacketReceivedEventArgs(SetSkillBarPacket packet) : base(packet) { }
        public new SetSkillBarPacket Packet { get { return (SetSkillBarPacket)base.Packet; } }
    }
    public delegate void SetSkillBarPacketReceivedEventHandler(object sender, SetSkillBarPacketReceivedEventArgs e);
}
