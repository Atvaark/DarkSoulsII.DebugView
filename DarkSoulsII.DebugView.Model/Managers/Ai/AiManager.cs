using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Ai;

namespace DarkSoulsII.DebugView.Model.Managers.Ai
{
    public class AiManager : IReadable<AiManager>
    {
        public ChrAi ChrAi { get; set; }

        public AiManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ChrAi = pointerFactory.Create<ChrAi>(address + 0x0014, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}
