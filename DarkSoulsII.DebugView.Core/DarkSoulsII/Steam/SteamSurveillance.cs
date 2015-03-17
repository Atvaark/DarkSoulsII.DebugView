namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Steam
{
    public class SteamSurveillance : IReadable<SteamSurveillance>
    {
        public bool Initialized { get; set; }
        public bool Online { get; set; }

        public SteamSurveillance Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Initialized = reader.ReadBoolean(address + 0x0108, relative);
            Online = reader.ReadBoolean(address + 0x0109, relative);
            return this;
        }
    }
}