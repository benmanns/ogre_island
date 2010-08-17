using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class ModifyBagItemPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public ModifyBagItemPacketReceivedEventArgs(ModifyBagItemPacket packet) : base(packet) { }
        public new ModifyBagItemPacket Packet { get { return (ModifyBagItemPacket)base.Packet; } }
    }
    public delegate void ModifyBagItemPacketReceivedEventHandler(object sender, ModifyBagItemPacketReceivedEventArgs e);
}
