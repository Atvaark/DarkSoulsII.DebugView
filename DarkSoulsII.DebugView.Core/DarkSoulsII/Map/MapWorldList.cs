namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map
{
    public class MapWorldList : IReadable<MapWorldList>
    {
        public MapWorldList Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
