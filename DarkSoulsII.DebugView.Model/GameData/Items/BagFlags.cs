using System;

namespace DarkSoulsII.DebugView.Model.GameData.Items
{
    [Flags]
    public enum BagFlags : byte
    {
        Unknown1 = 1,
        Equipped = 2,
        Unknown4 = 4,
        Unknown8 = 8,
        Unknown16 = 16,
        Unknown32 = 32,
        Unknown64 = 64,
        Unknown128 = 128
    }
}
