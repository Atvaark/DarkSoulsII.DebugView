﻿using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Map.Location
{
    public class MapGeneralAdviceBloodMsgLocation : MapGeneralBloodMsgLocation, IReadable<MapGeneralAdviceBloodMsgLocation>
    {
        public new MapGeneralAdviceBloodMsgLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}