using DarkSoulsII.DebugView.Core.DarkSoulsII.Character.Gestures;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Character
{
    public class ChrAsmCtrl : IReadable<ChrAsmCtrl>
    {
        public ChrAsmCtrlGestures Gestures { get; set; }
        public ChrAsmCtrlEquipment Equipment { get; set; }

        public ChrAsmCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Gestures = pointerFactory.Create<ChrAsmCtrlGestures>(address + 0x0010, relative).Unbox(pointerFactory, reader);
            Equipment = pointerFactory.Create<ChrAsmCtrlEquipment>(address + 0x0014, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
