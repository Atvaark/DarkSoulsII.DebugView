﻿namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Location.Phantom
{
    public class MapGeneralGeneratorLocation : MapGeneralPhantomLocation, IReadable<MapGeneralGeneratorLocation>
    {
        public new MapGeneralGeneratorLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}