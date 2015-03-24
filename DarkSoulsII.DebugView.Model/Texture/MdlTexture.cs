using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Texture
{
    public class MdlTexture : IReadable<MdlTexture>
    {
        public MdlTexture Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
