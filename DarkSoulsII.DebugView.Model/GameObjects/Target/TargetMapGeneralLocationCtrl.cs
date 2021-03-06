﻿using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Map.Location;
using DarkSoulsII.DebugView.Model.Rtti;

namespace DarkSoulsII.DebugView.Model.GameObjects.Target
{
    public class TargetMapGeneralLocationCtrl : TargetCtrl, IReadable<TargetMapGeneralLocationCtrl>
    {
        public MapGeneralLocation MapGeneralLocation { get; set; }

        public new TargetMapGeneralLocationCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            // BUG: Returns null, when the object was already overwritten.
            IPointer<MapGeneralLocation> locationPointer = new MapGeneralLocationResolver().ResolvePointer(pointerFactory, reader, reader.ReadInt32(address + 0x0010, relative));
            if(locationPointer != null)
                MapGeneralLocation = locationPointer.Unbox(pointerFactory, reader);
            return this;
        }

    }

}