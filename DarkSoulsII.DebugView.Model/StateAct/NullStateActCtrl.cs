using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.StateAct
{
    public class NullStateActCtrl : IReadable<NullStateActCtrl>
    {
        public StateActGraph StateActGraph { get; set; }

        public NullStateActCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            StateActGraph = pointerFactory.Create<StateActGraph>(address + 0x0004, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}