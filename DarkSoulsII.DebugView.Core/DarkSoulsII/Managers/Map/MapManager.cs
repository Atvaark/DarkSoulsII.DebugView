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
        public MapChameleonAreaManager ChameleonAreaManager { get; set; }

        public MapManager Read(IReader reader, int address, bool relative = false)
        {
            AreaManager = Pointer<MapAreaManager>.CreateAndUnbox(reader, address + 0x0004, relative);
            WorldList = Pointer<MapWorldList>.CreateAndUnbox(reader, address + 0x0008, relative);
            TextureManager = Pointer<MapTextureManager>.CreateAndUnbox(reader, address + 0x00C0);
            TextureResolutionManager = Pointer<MapTextureResolutionManager>.CreateAndUnbox(reader, address + 0x00C4,
                relative);
            WindManager = Pointer<MapWindManager>.CreateAndUnbox(reader, address + 0x00DC, relative);
            ItemPackManager = Pointer<MapItemPackManager>.CreateAndUnbox(reader, address + 0x00E4, relative);
            ChameleonAreaManager = Pointer<MapChameleonAreaManager>.CreateAndUnbox(reader, address + 0x0104, relative);
            return this;
        }
    }
}
