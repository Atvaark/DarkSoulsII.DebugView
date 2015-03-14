using System.Collections.Generic;
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
                    List<MapObjectBonfire> bonfires = new List<MapObjectBonfire>();
                    int bonfireAddress = a;
                    for (int i = 0; i < bonfireCount; i++, bonfireAddress += MapObjectBonfire.Size)
                    {
                        bonfires.Add(pointerFactory.Create<MapObjectBonfire>(bonfireAddress, relative, true).Unbox(pointerFactory, reader));
                    }

                    return bonfires;
                });
            CurrentTime = reader.ReadSingle(address + 0x002C, relative);
            return this;
        }
    }
}
