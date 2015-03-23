using DarkSoulsII.DebugView.Core.DarkSoulsII.Map;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Map
{
    public class MapManager : IReadable<MapManager>
    {
        public MapAreaManager AreaManager { get; set; }
        public MapWorldList WorldList { get; set; }
        public MapTextureManager TextureManager { get; set; }
        public MapTextureResolutionManager TextureResolutionManager { get; set; }
        public MapWindManager WindManager { get; set; }
        public MapItemPackManager ItemPackManager { get; set; }
        public MapStateActManager StateActManager { get; set; }
        public MapChameleonAreaManager ChameleonAreaManager { get; set; }

        public MapManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            AreaManager = pointerFactory.Create<MapAreaManager>(address + 0x0004, relative).Unbox(pointerFactory, reader);
            WorldList = pointerFactory.Create<MapWorldList>(address + 0x0008, relative).Unbox(pointerFactory, reader);
            TextureManager = pointerFactory.Create<MapTextureManager>(address + 0x00C0).Unbox(pointerFactory, reader);

            TextureResolutionManager = pointerFactory.Create<MapTextureResolutionManager>(address + 0x00C4, relative).Unbox(pointerFactory, reader);
            WindManager = pointerFactory.Create<MapWindManager>(address + 0x00DC, relative).Unbox(pointerFactory, reader);
            ItemPackManager = pointerFactory.Create<MapItemPackManager>(address + 0x00E4, relative).Unbox(pointerFactory, reader);
            StateActManager = pointerFactory.Create<MapStateActManager>(address + 0x00FC, relative).Unbox(pointerFactory, reader);
            ChameleonAreaManager = pointerFactory.Create<MapChameleonAreaManager>(address + 0x0104, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}
