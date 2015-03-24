using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Savegame
{
    public class ContentFormat : IReadable<ContentFormat>
    {
        public ContentFormat Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}