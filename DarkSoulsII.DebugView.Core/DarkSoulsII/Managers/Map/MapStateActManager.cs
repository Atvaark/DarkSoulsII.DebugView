using System.Collections.Generic;
using System.Linq;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Map
{
    public class MapStateActManager : IReadable<MapStateActManager>
    {

        public MapStateActManager()
        {
            StateActList = new List<MapStateAct>();
        }

        public List<MapStateAct> StateActList { get; set; }

        public MapStateActManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            bool initialized = reader.ReadBoolean(address + 0x0004, relative);
            if (initialized)
            {
                StateActList =  pointerFactory.CreateArrayDereferenced<MapStateAct>(address + 0x0014, relative, 42)
                    .Select(p => p.Unbox(pointerFactory, reader))
                    .ToList();
            }
            return this;
        }

    }
}