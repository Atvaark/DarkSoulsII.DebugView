using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class ChrCullingParam : IReadable<ChrCullingParam>
    {
        public ChrCullingParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
