using DarkSoulsII.DebugView.Core.DarkSoulsII.Controllers;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Map
{
    public class MapTextureResolutionManager : IReadable<MapTextureResolutionManager>
    {
        public MapTextureResolutionCtrl TextureResolutionCtrl { get; set; }

        public MapTextureResolutionManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            TextureResolutionCtrl = pointerFactory.Create<MapTextureResolutionCtrl>(address + 0x0004, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
