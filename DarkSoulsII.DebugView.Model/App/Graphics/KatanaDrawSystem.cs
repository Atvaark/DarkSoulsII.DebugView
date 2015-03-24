using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.App.Graphics.Filters;

namespace DarkSoulsII.DebugView.Model.App.Graphics
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
        public AppDepthOfFieldFilter DepthOfFieldFilter { get; set; }

        public KatanaDrawSystem Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ToneMapFilter = pointerFactory.Create<GxToneMapFilter>(address + 0x10E8, relative).Unbox(pointerFactory, reader);
            LensSimulationFilter = pointerFactory.Create<GxLensSimulationFilter>(address + 0x11AC, relative).Unbox(pointerFactory, reader);
            LensFlareFilter = pointerFactory.Create<GxLensFlareFilter>(address + 0x11B0, relative).Unbox(pointerFactory, reader);
            FogFilter = pointerFactory.Create<AppFogFilter>(address + 0x11B4, relative).Unbox(pointerFactory, reader);
            VolumeFogFilter = pointerFactory.Create<AppVolumeFogFilter>(address + 0x11B8, relative).Unbox(pointerFactory, reader);
            LightFilter = pointerFactory.Create<AppLightFilter>(address + 0x11BC, relative).Unbox(pointerFactory, reader);
            VignettingFilter = pointerFactory.Create<AppVignettingFilter>(address + 0x11C0, relative).Unbox(pointerFactory, reader);
            BlackOutFilter = pointerFactory.Create<AppBlackOutFilter>(address + 0x11C4, relative).Unbox(pointerFactory, reader);
            DepthOfFieldFilter = pointerFactory.Create<AppDepthOfFieldFilter>(address + 0x11C8, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}
