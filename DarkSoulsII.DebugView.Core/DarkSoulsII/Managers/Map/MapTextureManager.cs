using DarkSoulsII.DebugView.Core.DarkSoulsII.Drawing;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Character;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Map
{
    public class MapTextureManager : IReadable<MapTextureManager>
    {
        public ChrTextureManager ChrTextureManager { get; set; }
        public MapTexture MapTexture1 { get; set; }
        public MapTexture MapTexture2 { get; set; }

        public MapTextureManager Read(IReader reader, int address, bool relative = false)
        {
            ChrTextureManager = Pointer<ChrTextureManager>.CreateAndUnbox(reader, address + 0x0004, relative);
            MapTexture1 = Pointer<MapTexture>.CreateAndUnbox(reader, address + 0x0014, relative);
            MapTexture2 = Pointer<MapTexture>.CreateAndUnbox(reader, address + 0x0018, relative);
            return this;
        }
    }
}
