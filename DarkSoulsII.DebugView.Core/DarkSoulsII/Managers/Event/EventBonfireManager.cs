using System.Collections.Generic;
using System.Linq;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Events;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Event
{
    public class EventBonfireManager : IReadable<EventBonfireManager>
    {
        public List<MapObjectBonfire> Bonfires { get; set; }
        public float CurrentTime { get; set; }

        public EventBonfireManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int bonfireCount = reader.ReadInt32(address + 0x0014);
            Bonfires = GenericPointer.Create(reader, address + 0x0010, relative).Unbox(reader,
                (r, a) =>
                {
                    return pointerFactory
                        .CreateArrayDereferenced<MapObjectBonfire>(a, false, bonfireCount)
                        .Select(p => p.Unbox(pointerFactory, reader)).ToList();
                });
            CurrentTime = reader.ReadSingle(address + 0x002C, relative);
            return this;
        }
    }
}
