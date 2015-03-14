﻿using System.Collections.Generic;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Area
{
    public class MapChameleonArea : IReadable<MapChameleonArea>
    {
        public MapChameleonArea()
        {
            ChameleonAreaDataList = new List<MapChameleonAreaData>();
        }

        public List<MapChameleonAreaData> ChameleonAreaDataList { get; set; }

        public MapChameleonArea Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int chameleonDataAddress = address + 0x0010;
            for (int i = 0; i < 3; i++, chameleonDataAddress += MapChameleonAreaData.Size)
            {
                var data = pointerFactory.Create<MapChameleonAreaData>(chameleonDataAddress, relative, true).Unbox(pointerFactory, reader);
                ChameleonAreaDataList.Add(data);
            }

            int chameleonDataCount = reader.ReadInt32(address + 0x0064, relative);

            return this;
        }
    }
}
