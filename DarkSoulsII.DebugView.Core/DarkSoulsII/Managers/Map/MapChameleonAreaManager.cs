using DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Area;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Map
{
    public class MapChameleonAreaManager : IReadable<MapChameleonAreaManager>
    {
        public MapChameleonArea Area { get; set; }

        public MapChameleonAreaManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // BUG: Sometimes +0020 is just +0014 (value: 1019) and not a pointer.
            // Either check the value for equality or catch the exception.
            Area = pointerFactory.Create<MapChameleonArea>(address, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
