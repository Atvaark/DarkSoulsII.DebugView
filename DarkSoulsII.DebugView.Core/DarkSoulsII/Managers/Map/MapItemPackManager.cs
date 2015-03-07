using DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Item;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Map
{
    public class MapItemPackManager : IReadable<MapItemPackManager>
    {
        public MapItemPackTable ItemPackTable { get; set; }

        public MapItemPackManager Read(IReader reader, int address, bool relative = false)
        {
            ItemPackTable = Pointer<MapItemPackTable>.CreateAndUnbox(reader, address + 0x0004, relative);
            return this;
        }
    }
}
