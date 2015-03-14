﻿using DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Item;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Map
{
    public class MapItemPackManager : IReadable<MapItemPackManager>
    {
        public MapItemPackTable ItemPackTable { get; set; }

        public MapItemPackManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ItemPackTable = pointerFactory.Create<MapItemPackTable>(address + 0x0004, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
