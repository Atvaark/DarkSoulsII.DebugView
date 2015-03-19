using System.Collections.Generic;
using System.Linq;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.EnemyGenerator
{
    public class EnemyGeneratorDeadCounter : IReadable<EnemyGeneratorDeadCounter>
    {
        public List<MapDeadCounter> MapCounters { get; set; }

        public EnemyGeneratorDeadCounter Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            MapCounters = pointerFactory
                .CreateArrayDereferenced<MapDeadCounter>(address + 0004, relative, 42)
                .Select(p => p.Unbox(pointerFactory, reader))
                .ToList();
            return this;
        }

    }
}