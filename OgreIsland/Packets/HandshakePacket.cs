namespace OgreIsland.Packets
{
    public class HandshakePacket : AbstractPacket
    {
        public HandshakePacket() : base(new Packet("HANDSHAKE", null)) { }
        public HandshakePacket(Packet packet) : base(packet) { }
        public string Authentication
        {
            get
            {
                return Arguments.Length == 0 ? string.Empty : Arguments[0];
            }
            set
            {
                if (value == string.Empty) Arguments = null;
                else if (Arguments == null || Arguments.Length == 0) Arguments = new[] { value };
                else Arguments[0] = value;
            }
        }
    }
}
