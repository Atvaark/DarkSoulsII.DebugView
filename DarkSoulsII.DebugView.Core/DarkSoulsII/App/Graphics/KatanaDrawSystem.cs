using DarkSoulsII.DebugView.Core.DarkSoulsII.App.Graphics.Filters;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.App.Graphics
{
    public class KatanaDrawSystem : IReadable<KatanaDrawSystem>
    {
        public GxToneMapFilter ToneMapFilter { get; set; }
        public GxLensSimulationFilter LensSimulationFilter { get; set; }
        public GxLensFlareFilter LensFlareFilter { get; set; }
        public AppFogFilter FogFilter { get; set; }
        public AppVolumeFogFilter VolumeFogFilter { get; set; }
        public AppLightFilter LightFilter { get; set; }
        public AppVignettingFilter VignettingFilter { get; set; }
        public AppBlackOutFilter BlackOutFilter { get; set; }

        public KatanaDrawSystem Read(IReader reader, int address, bool relative = false)
        {
            ToneMapFilter = Pointer<GxToneMapFilter>.CreateAndUnbox(reader, address + 0x10E8, relative);
            LensSimulationFilter = Pointer<GxLensSimulationFilter>.CreateAndUnbox(reader, address + 0x11AC, relative);
            LensFlareFilter = Pointer<GxLensFlareFilter>.CreateAndUnbox(reader, address + 0x11B0, relative);
            FogFilter = Pointer<AppFogFilter>.CreateAndUnbox(reader, address + 0x11B4, relative);
            VolumeFogFilter = Pointer<AppVolumeFogFilter>.CreateAndUnbox(reader, address + 0x11B8, relative);
            LightFilter = Pointer<AppLightFilter>.CreateAndUnbox(reader, address + 0x11BC, relative);
            VignettingFilter = Pointer<AppVignettingFilter>.CreateAndUnbox(reader, address + 0x11C0, relative);
            BlackOutFilter = Pointer<AppBlackOutFilter>.CreateAndUnbox(reader, address + 0x11C4, relative);
            return this;
        }
    }
}
