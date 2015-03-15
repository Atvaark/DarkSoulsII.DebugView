using DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Area;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Map
{
    public class MapChameleonAreaManager : IReadable<MapChameleonAreaManager>
    {
        public MapChameleonArea Area { get; set; }

        public MapChameleonAreaManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TryUnbox gets called because during initialization +0x0014 and +0x0020 are equal to 1019 and not a pointer.
            Area = pointerFactory.Create<MapChameleonArea>(address + 0x0020, relative).TryUnbox(pointerFactory, reader);
            return this;
        }
    }
}
