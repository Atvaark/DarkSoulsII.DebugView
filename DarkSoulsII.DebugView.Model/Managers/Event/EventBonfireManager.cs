using System.Collections.Generic;
using System.Linq;
using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Events;

namespace DarkSoulsII.DebugView.Model.Managers.Event
{
    public class EventBonfireManager : IReadable<EventBonfireManager>
    {
        public List<MapObjectBonfire> Bonfires { get; set; }
        public float CurrentTime { get; set; }

        public EventBonfireManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int bonfireCount = reader.ReadInt32(address + 0x0014);
            int bonfireAddress = reader.ReadInt32(address + 0x0010, relative);
            Bonfires = pointerFactory
                .CreateArrayDereferenced<MapObjectBonfire>(bonfireAddress, false, bonfireCount)
                .Select(p => p.Unbox(pointerFactory, reader))
                .ToList();
            CurrentTime = reader.ReadSingle(address + 0x002C, relative);
            return this;
        }
    }
}
