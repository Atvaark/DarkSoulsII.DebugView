using System.Collections.Generic;
using System.Linq;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.EnemyGenerator
{
    public class EnemyGeneratorAreaCtrl : IReadable<EnemyGeneratorAreaCtrl>
    {
        public EnemyGeneratorAreaCtrl()
        {
            EnemyGeneratorControllers = new List<EnemyGeneratorCtrl>();
        }

        public List<EnemyGeneratorCtrl> EnemyGeneratorControllers { get; set; }
        
        public EnemyGeneratorAreaCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            int enemyGeneratorCount = reader.ReadInt32(address + 0x0014, relative);
            int enemyGeneratorAddress = reader.ReadInt32(address + 0x0010, relative);
            EnemyGeneratorControllers = pointerFactory.CreateArray<EnemyGeneratorCtrl>(enemyGeneratorAddress, false, enemyGeneratorCount)
                .Select(p=>p.Unbox(pointerFactory,reader))
                .ToList();

            // 002C GeneratorParamMem
            // 0030 GeneratorRegistParam
            // 0034 GeneratorLocationParam
            return this;
        }

    }
}