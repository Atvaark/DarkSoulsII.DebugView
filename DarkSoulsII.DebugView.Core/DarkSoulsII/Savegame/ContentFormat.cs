namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Savegame
{
    public class ContentFormat : IReadable<ContentFormat>
    {
        public ContentFormat Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}