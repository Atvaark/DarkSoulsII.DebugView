namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Savegame
{
    public class LoadContent : IReadable<LoadContent>
    {
        public LoadContent Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}