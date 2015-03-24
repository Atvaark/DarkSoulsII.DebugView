using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Ai
{
    public class ChrAi : ChrAiBase, IReadable<ChrAi>
    {
        public SearchEzStateCtrl SearchEzStateCtrl { get; set; }
        public ChrAiNavimeshCtrl ChrAiNavimeshCtrl { get; set; }
        public ChrAiMapObjectCtrl ChrAiMapObjectCtrl { get; set; }

        public new ChrAi Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            SearchEzStateCtrl = pointerFactory.Create<SearchEzStateCtrl>(address + 0x0050, relative, true).Unbox(pointerFactory, reader);
            ChrAiNavimeshCtrl = pointerFactory.Create<ChrAiNavimeshCtrl>(address + 0x0570, relative, true).Unbox(pointerFactory, reader);
            ChrAiMapObjectCtrl = pointerFactory.Create<ChrAiMapObjectCtrl>(address + 0x0570, relative, true).Unbox(pointerFactory, reader);
            return this;
        }

    }
}