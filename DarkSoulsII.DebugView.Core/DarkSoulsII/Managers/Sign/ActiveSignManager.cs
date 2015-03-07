using System.Collections.Generic;
using DarkSoulsII.DebugView.Core.DarkSoulsII.Controllers;

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

        public ActiveSignManager Read(IReader reader, int address, bool relative = false)
        {
            Initialized = reader.ReadBoolean(address + 0x0008, relative);
            int activeSignCount = reader.ReadInt32(address + 0x000C, relative);

            ActiveSigns = GenericPointer.Create(reader, address + 0x0010, relative).Unbox(reader,
                (r, a) =>
                {
                    List<ActiveSignCtrl> activeSigns = new List<ActiveSignCtrl>();
                    int activeSignAddress = a;
                    for (int i = 0; i < activeSignCount; i++, activeSignAddress += ActiveSignCtrl.Size)
                    {
                        activeSigns.Add(Pointer<ActiveSignCtrl>.Create(activeSignAddress, relative).Unbox(reader));
                    }
                    return activeSigns;
                });

            return this;
        }
    }
}
