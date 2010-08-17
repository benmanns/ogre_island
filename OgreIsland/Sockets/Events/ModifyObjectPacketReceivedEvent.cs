using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class ModifyObjectPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public ModifyObjectPacketReceivedEventArgs(ModifyObjectPacket packet) : base(packet) { }
        public new ModifyObjectPacket Packet { get { return (ModifyObjectPacket)base.Packet; } }
    }
    public delegate void ModifyObjectPacketReceivedEventHandler(object sender, ModifyObjectPacketReceivedEventArgs e);
}
