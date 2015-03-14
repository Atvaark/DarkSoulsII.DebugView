using System.Collections.Generic;
using DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Area;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Map
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

            int ownersAddress = address + 0x001C;
            for (int i = 0; i < 38; i++, ownersAddress += Pointer<MapAreaCtrlOwner>.Size)
            {
                MapAreaCtrlOwner owner = pointerFactory.Create<MapAreaCtrlOwner>(ownersAddress, relative).Unbox(pointerFactory, reader);
                Owners.Add(owner);
            }

            short areaCtrlOwnerCount = reader.ReadInt16(address + 0x0C8, relative);
            return this;
        }
    }
}
