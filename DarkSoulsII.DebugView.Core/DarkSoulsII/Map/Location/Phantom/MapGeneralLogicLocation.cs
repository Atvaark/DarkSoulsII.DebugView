﻿namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Location.Phantom
{
    public class MapGeneralLogicLocation : MapGeneralPhantomLocation, IReadable<MapGeneralLogicLocation>
    {
        public new MapGeneralLogicLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}