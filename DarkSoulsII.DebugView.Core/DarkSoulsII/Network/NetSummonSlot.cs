using DarkSoulsII.DebugView.Core.DarkSoulsII.GameObjects.GameEntities;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Network
{
    public class NetSummonSlot : IReadable<NetSummonSlot>, IFixedSize
    {
        public string Name { get; set; }
        public PlayerCtrl PlayerControl { get; set; }
        public int Size
        {
            get { return 176; }
        }

        public NetSummonSlot Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            // Mutex 0004-0020

            PlayerControl = pointerFactory.Create<PlayerCtrl>(address + 0x0024).Unbox(pointerFactory, reader);
            Name = reader.ReadAnsiString(62, address + 0x006C, relative).Replace("\0", "");
            return this;
        }

    }
}
