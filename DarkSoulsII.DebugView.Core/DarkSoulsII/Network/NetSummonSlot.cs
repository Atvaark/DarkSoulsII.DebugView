using DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Network
{
    public class NetSummonSlot : IReadable<NetSummonSlot>
    {
        public string Name { get; set; }
        public PlayerCtrl PlayerControl { get; set; }

        public NetSummonSlot Read(IReader reader, int address, bool relative = false)
        {
            // Mutex 0004-0020

            PlayerControl = Pointer<PlayerCtrl>.CreateAndUnbox(reader, address + 0x0024);
            Name = reader.ReadString(62, address + 0x006C, relative).Replace("\0", "");
            return this;
        }
    }
}
