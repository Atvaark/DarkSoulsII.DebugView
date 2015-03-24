using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Savegame
{
    public class LoadContent : IReadable<LoadContent>
    {
        public LoadContent Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}