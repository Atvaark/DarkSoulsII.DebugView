using System.Collections.Generic;
using System.Linq;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Network;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Network
{
    public class NetSummonSlotManager : IReadable<NetSummonSlotManager>
    {
        public NetSummonSlotManager()
        {
            Slots = new List<NetSummonSlot>();
        }

        public List<NetSummonSlot> Slots { get; set; }

        public NetSummonSlotManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Slots = pointerFactory
                .CreateArrayDereferenced<NetSummonSlot>(address + 0x0108, relative, 4)
                .Select(p => p.Unbox(pointerFactory, reader))
                .ToList();
            return this;
        }
    }
}
