using System.Collections.Generic;
using System.Linq;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Sign;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Sign
{
    public class ActiveSignManager : IReadable<ActiveSignManager>
    {
        public ActiveSignManager()
        {
            ActiveSigns = new List<ActiveSignCtrl>();
        }

        public bool Initialized { get; set; }
        public List<ActiveSignCtrl> ActiveSigns { get; set; }

        public ActiveSignManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Initialized = reader.ReadBoolean(address + 0x0008, relative);
            int activeSignCount = reader.ReadInt32(address + 0x000C, relative);

            ActiveSigns = GenericPointer.Create(reader, address + 0x0010, relative).Unbox(reader,
                (r, a) =>
                {
                    return pointerFactory
                        .CreateArrayDereferenced<ActiveSignCtrl>(a, false, activeSignCount)
                        .Select(p => p.Unbox(pointerFactory, reader)).ToList();
                });
            return this;
        }
    }
}
