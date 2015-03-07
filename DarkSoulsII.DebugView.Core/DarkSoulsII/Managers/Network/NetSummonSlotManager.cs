using System.Collections.Generic;
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

        public NetSummonSlotManager Read(IReader reader, int address, bool relative = false)
        {
            for (int i = 0; i < 3; i++)
            {
                var slot = Pointer<NetSummonSlot>.Create(address + 0x0108 + i*0xB0).Unbox(reader);
                Slots.Add(slot);
            }
            return this;
        }
    }
}
