using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Texture
{
    public class MapTextureResolutionCtrl : IReadable<MapTextureResolutionCtrl>
    {
        public MapTextureResolutionCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
