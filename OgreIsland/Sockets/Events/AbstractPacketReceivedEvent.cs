namespace OgreIsland.Sockets.Events
{
    public class AbstractPacketReceivedEventArgs : ReceivedEventArgs
    {
        public AbstractPacketReceivedEventArgs(AbstractPacket packet) : base(packet) { }
    }
    public delegate void AbstractPacketReceivedEventHandler(object sender, AbstractPacketReceivedEventArgs e);
}
