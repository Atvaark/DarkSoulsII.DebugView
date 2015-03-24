using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Sign;

namespace DarkSoulsII.DebugView.Model.Managers.Sign
{
    public class SignSetCtrlManager : IReadable<SignSetCtrlManager>
    {
        public BloodMessageSetCtrl BloodMessageSetCtrl { get; set; }
        public SummonSignSetCtrl SummonSignSetCtrl { get; set; }
        public BloodstainSetCtrl BloodstainSetCtrl { get; set; }

        public SignSetCtrlManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            BloodMessageSetCtrl = pointerFactory.Create<BloodMessageSetCtrl>(address + 0x000C, relative).Unbox(pointerFactory, reader);
            SummonSignSetCtrl = pointerFactory.Create<SummonSignSetCtrl>(address + 0x0010, relative).Unbox(pointerFactory, reader);
            BloodstainSetCtrl = pointerFactory.Create<BloodstainSetCtrl>(address + 0x0014, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
