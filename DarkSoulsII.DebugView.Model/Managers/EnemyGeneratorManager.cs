using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.EnemyGenerator;

namespace DarkSoulsII.DebugView.Model.Managers
{
    public class EnemyGeneratorManager : IReadable<EnemyGeneratorManager>
    {
        public EnemyGeneratorDeadCounter DeadCounter { get; set; }
        public EnemyGeneratorPacketCtrl PacketCtrl { get; set; }
        public EnemyGeneratorAreaChrStatus AreaChrStatus { get; set; }
        public EnemyGeneratorAreaCtrl AreaCtrl { get; set; }

        public EnemyGeneratorManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            DeadCounter = pointerFactory.Create<EnemyGeneratorDeadCounter>(address + 0x0014, relative).Unbox(pointerFactory, reader);
            PacketCtrl = pointerFactory.Create<EnemyGeneratorPacketCtrl>(address + 0x0018, relative).Unbox(pointerFactory, reader);
            AreaChrStatus = pointerFactory.Create<EnemyGeneratorAreaChrStatus>(address + 0x0020, relative).Unbox(pointerFactory, reader);
            AreaCtrl = pointerFactory.Create<EnemyGeneratorAreaCtrl>(address + 0x00C8, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}