using System.Collections.Generic;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Character.Gestures
{
    public class ChrAsmCtrlGestures : IReadable<ChrAsmCtrlGestures>
    {
        public ChrAsmCtrlGestures()
        {
            Gestures = new List<ChrAsmCtrlGesture>();
        }

        public List<ChrAsmCtrlGesture> Gestures { get; set; }

        public ChrAsmCtrlGestures Read(IReader reader, int address, bool relative = false)
        {
            int gestureAddress = address + 0x0004;
            for (int i = 0; i < 52; i++, gestureAddress += 20)
            {
                // TODO: Check what the values < 44 are
                if (i >= 44)
                    Gestures.Add(Pointer<ChrAsmCtrlGesture>.Create(gestureAddress, relative).Unbox(reader));
            }
            return this;
        }
    }
}
