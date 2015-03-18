namespace DarkSoulsII.DebugView.Core.DarkSoulsII.App.Graphics.Filters
{
    public class GxToneMapFilter : IReadable<GxToneMapFilter>
    {
        public float DarknessIntensity1 { get; set; }
        public float DarknessIntensity2 { get; set; }
        public float DarknessThreshold { get; set; }
        public float SkyboxRed1 { get; set; }
        public float SkyboxRed2 { get; set; }
        public float SkyboxRed3 { get; set; }
        public float SkyboxRedIntensity { get; set; }
        public float FogRedTint { get; set; }
        public float FogGreenTint { get; set; }
        public float FogBlueTint { get; set; }
        public float FogAlphaTint { get; set; }

        public GxToneMapFilter Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            DarknessIntensity1 = reader.ReadSingle(address + 0x0074, relative);
            DarknessIntensity2 = reader.ReadSingle(address + 0x0078, relative);
            DarknessThreshold = reader.ReadSingle(address + 0x007C, relative);

            SkyboxRed1 = reader.ReadSingle(address + 0x00B0, relative);
            SkyboxRed2 = reader.ReadSingle(address + 0x00B4, relative);
            SkyboxRed3 = reader.ReadSingle(address + 0x00B8, relative);
            SkyboxRedIntensity = reader.ReadSingle(address + 0x00BC, relative);
            FogRedTint = reader.ReadSingle(address + 0x00C0, relative);
            FogGreenTint = reader.ReadSingle(address + 0x00C4, relative);
            FogBlueTint = reader.ReadSingle(address + 0x00C8, relative);
            FogAlphaTint = reader.ReadSingle(address + 0x00CC, relative);

            return this;
        }

    }
}
