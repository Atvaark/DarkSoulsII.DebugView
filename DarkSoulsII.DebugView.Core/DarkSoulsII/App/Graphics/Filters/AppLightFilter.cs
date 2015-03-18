namespace DarkSoulsII.DebugView.Core.DarkSoulsII.App.Graphics.Filters
{
    public class AppLightFilter : IReadable<AppLightFilter>
    {
        public ColorVector4 WorldLightningDirect { get; set; }
        public ColorVector4 WorldLightningSpecularity { get; set; }
        public ColorVector4 PropLightning1 { get; set; }
        public ColorVector4 PropShadowBrightness { get; set; }
        public ColorVector4 WorldLightningShadowBrightness { get; set; }
        public ColorVector4 WorldLightningNormalmapBrightness { get; set; }
        public ColorVector4 PropRefractoryLight { get; set; }
        public ColorVector4 PropLightning2 { get; set; }
        public float SunAngleHorizontal1 { get; set; }
        public float SunAngleHeight { get; set; }
        public float SunAngleHorizontal2 { get; set; }
        public bool VolumetricLight { get; set; }
        public bool StaticShadows { get; set; }
        public ColorVector4 ModelLightningGeneralLightmap { get; set; }
        public ColorVector4 ModelLightningGeneralSpecularity { get; set; }
        public ColorVector4 ModelLightningGeneralModelBrightness { get; set; }
        public ColorVector4 ModelLightningPlayerRefractoryLight { get; set; }
        public ColorVector4 ModelLightningPlayerBrightness { get; set; }
        public ColorVector4 ModelLightningCharacterBrightness { get; set; }

        public AppLightFilter Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            WorldLightningDirect = pointerFactory.Create<ColorVector4>(address + 0x0010, relative, true).Unbox(pointerFactory, reader);
            WorldLightningSpecularity = pointerFactory.Create<ColorVector4>(address + 0x0020, relative, true).Unbox(pointerFactory, reader);

            PropLightning1 = pointerFactory.Create<ColorVector4>(address + 0x0030, relative, true).Unbox(pointerFactory, reader);
            PropShadowBrightness = pointerFactory.Create<ColorVector4>(address + 0x0040, relative, true).Unbox(pointerFactory, reader);
            WorldLightningShadowBrightness = pointerFactory.Create<ColorVector4>(address + 0x0050, relative, true).Unbox(pointerFactory, reader);
            WorldLightningNormalmapBrightness = pointerFactory.Create<ColorVector4>(address + 0x0060, relative, true).Unbox(pointerFactory, reader);
            PropRefractoryLight = pointerFactory.Create<ColorVector4>(address + 0x0070, relative, true).Unbox(pointerFactory, reader);
            PropLightning2 = pointerFactory.Create<ColorVector4>(address + 0x00B0, relative, true).Unbox(pointerFactory, reader);

            SunAngleHorizontal1 = reader.ReadSingle(address + 0x0100, relative);
            SunAngleHeight = reader.ReadSingle(address + 0x0104, relative);
            SunAngleHorizontal2 = reader.ReadSingle(address + 0x0108, relative);

            VolumetricLight = reader.ReadBoolean(address + 0x0120, relative);
            StaticShadows = reader.ReadBoolean(address + 0x0122, relative);

            ModelLightningGeneralLightmap = pointerFactory.Create<ColorVector4>(address + 0x0130, relative, true).Unbox(pointerFactory, reader);
            ModelLightningGeneralSpecularity = pointerFactory.Create<ColorVector4>(address + 0x0140, relative, true).Unbox(pointerFactory, reader);
            
            ModelLightningGeneralModelBrightness = pointerFactory.Create<ColorVector4>(address + 0x0180, relative, true).Unbox(pointerFactory, reader);
            ModelLightningPlayerRefractoryLight = pointerFactory.Create<ColorVector4>(address + 0x0190, relative, true).Unbox(pointerFactory, reader);
            ModelLightningPlayerBrightness = pointerFactory.Create<ColorVector4>(address + 0x01D0, relative, true).Unbox(pointerFactory, reader);
            ModelLightningCharacterBrightness = pointerFactory.Create<ColorVector4>(address + 0x01E0, relative, true).Unbox(pointerFactory, reader);

            return this;
        }

    }
}
