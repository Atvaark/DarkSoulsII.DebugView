using System.Collections.Generic;
using System.Linq;
using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Managers.Map
{
    public class MapStateAct : IReadable<MapStateAct>, IFixedSize
    {

        public MapStateAct()
        {
            Entries = new List<MapStateActEntry>();
        }

        public List<MapStateActEntry> Entries { get; set; }
        public int Size
        {
            get { return 3080; }
        }
        public MapStateAct Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int count = reader.ReadInt32(address + 0x0004, relative);

            Entries = pointerFactory.CreateArrayDereferenced<MapStateActEntry>(address + 0x0008, relative, count)
                .Select(p => p.Unbox(pointerFactory, reader))
                .ToList();
            return this;
        }

    }
}