using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Savegame
{
    public class SaveContent : IReadable<SaveContent>
    {
        public SaveContent Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}