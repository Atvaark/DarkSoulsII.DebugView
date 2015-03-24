using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers.Character
{
    public class ChrTextureManager : IReadable<ChrTextureManager>
    {
        public ChrTextureManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
