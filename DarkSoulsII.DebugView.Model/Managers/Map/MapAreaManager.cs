using System.Collections.Generic;
using System.Linq;
using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.GameObjects.GameEntities;
using DarkSoulsII.DebugView.Model.Map.Area;

namespace DarkSoulsII.DebugView.Model.Managers.Map
{
    public class MapAreaManager : IReadable<MapAreaManager>
    {
        public MapAreaManager()
        {
            Owners = new List<MapAreaCtrlOwner>();
        }

        public MapEntity Entity1 { get; set; }
        public MapEntity Entity2 { get; set; }
        public List<MapAreaCtrlOwner> Owners { get; set; }

        public MapAreaManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Entity1 = pointerFactory.Create<MapEntity>(address + 0x0010, relative).Unbox(pointerFactory, reader);
            Entity2 = pointerFactory.Create<MapEntity>(address + 0x0014, relative).Unbox(pointerFactory, reader);

            short areaCtrlOwnerCount = reader.ReadInt16(address + 0x0C8, relative);
            Owners = pointerFactory
                .CreateArray<MapAreaCtrlOwner>(address + 0x001C, relative, areaCtrlOwnerCount)
                .Select(p => p.Unbox(pointerFactory, reader)).ToList();
            return this;
        }
    }
}
