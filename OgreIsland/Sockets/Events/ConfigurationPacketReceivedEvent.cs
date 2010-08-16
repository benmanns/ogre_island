using OgreIsland.Packets;

namespace OgreIsland.Sockets.Events
{
    public class ConfigurationPacketReceivedEventArgs : AbstractPacketReceivedEventArgs
    {
        public ConfigurationPacketReceivedEventArgs(ConfigurationPacket packet) : base(packet) { }
        public new ConfigurationPacket Packet { get { return (ConfigurationPacket)base.Packet; } }
    }
    public delegate void ConfigurationPacketReceivedEventHandler(object sender, ConfigurationPacketReceivedEventArgs e);
}
