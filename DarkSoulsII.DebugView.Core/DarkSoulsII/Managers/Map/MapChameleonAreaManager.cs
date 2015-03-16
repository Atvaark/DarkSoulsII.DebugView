using DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Area;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Map
{
    public class MapChameleonAreaManager : IReadable<MapChameleonAreaManager>
    {
        public MapChameleonArea Area { get; set; }

        public MapChameleonAreaManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // TODO: Check how the game initializes the pointer and if 1019 is a hard coded default value
            // This checks if the pointer at +0x0020 is initialized or has the default value (1019).
            bool initialized = reader.ReadInt32(address + 0x0014, relative) != reader.ReadInt32(address + 0x0020, relative);
            if (initialized == false)
                return this;
            Area = pointerFactory.Create<MapChameleonArea>(address + 0x0020, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
