using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class WeatherPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public WeatherPacketReceivedEventArgs(WeatherPacket packet) : base(packet) { }
        public new WeatherPacket Packet { get { return (WeatherPacket)base.Packet; } }
    }
    public delegate void WeatherPacketReceivedEventHandler(object sender, WeatherPacketReceivedEventArgs e);
}
