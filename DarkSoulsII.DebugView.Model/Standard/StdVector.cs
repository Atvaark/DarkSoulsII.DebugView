using System.Collections.Generic;
using System.Linq;
using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Standard
{
    public class StdVector<T> : IReadable<StdVector<T>> where T : class, IReadable<T>, new()
    {
        public List<T> Entries { get; set; }

        public StdVector()
        {
            Entries = new List<T>();
        }

        public StdVector<T> Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int bottomAddress = reader.ReadInt32(address + 0x0000, relative);
            int topAddress = reader.ReadInt32(address + 0x0004, relative);
            int count = (topAddress - bottomAddress)/sizeof(int);
            Entries =  pointerFactory.CreateArray<T>(bottomAddress, false, count)
                .Select(p => p.Unbox(pointerFactory, reader))
                .ToList();
            return this;
        }
    }
}