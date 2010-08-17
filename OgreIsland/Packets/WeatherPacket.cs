namespace OgreIsland.Packets
{
    public class WeatherPacket : AbstractPacket
    {
        public WeatherPacket() : base(new Packet("WEATHER", new string[6])) { }
        public WeatherPacket(Packet packet) : base(packet) { }
        public string Name { get { return Arguments[0]; } set { Arguments[0] = value; } }
        public string Frame { get { return Arguments[1]; } set { Arguments[1] = value; } }
        public string Count { get { return Arguments[2]; } set { Arguments[2] = value; } }
        public string Size { get { return Arguments[3]; } set { Arguments[3] = value; } }
        public string Gravity { get { return Arguments[4]; } set { Arguments[4] = value; } }
        public string Wind { get { return Arguments[5]; } set { Arguments[5] = value; } }
    }
}
