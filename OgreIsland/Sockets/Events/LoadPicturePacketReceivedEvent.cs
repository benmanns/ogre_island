using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class LoadPicturePacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public LoadPicturePacketReceivedEventArgs(LoadPicturePacket packet) : base(packet) { }
        public new LoadPicturePacket Packet { get { return (LoadPicturePacket)base.Packet; } }
    }
    public delegate void LoadPicturePacketReceivedEventHandler(object sender, LoadPicturePacketReceivedEventArgs e);
}
