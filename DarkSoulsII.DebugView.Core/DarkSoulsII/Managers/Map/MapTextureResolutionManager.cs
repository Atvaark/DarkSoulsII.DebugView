using DarkSoulsII.DebugView.Core.DarkSoulsII.Controllers;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Map
{
    public class MapTextureResolutionManager : IReadable<MapTextureResolutionManager>
    {
        public MapTextureResolutionCtrl TextureResolutionCtrl { get; set; }

        public MapTextureResolutionManager Read(IReader reader, int address, bool relative = false)
        {
            TextureResolutionCtrl = Pointer<MapTextureResolutionCtrl>.CreateAndUnbox(reader, address + 0x0004, relative);
            return this;
        }
    }
}
