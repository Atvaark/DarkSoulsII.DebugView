﻿namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Map.Location.Phantom
{
    public class MapGeneralDamageLocation : MapGeneralPhantomLocation, IReadable<MapGeneralDamageLocation>
    {
        public new MapGeneralDamageLocation Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}