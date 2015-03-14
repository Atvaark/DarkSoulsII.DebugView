namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Character.Gestures
{
    public class ChrAsmCtrlGesture : IReadable<ChrAsmCtrlGesture>
    {
        public GestureType Gesture { get; set; }

        public ChrAsmCtrlGesture Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Gesture = (GestureType) reader.ReadInt32(address + 0x0004, relative);
            return this;
        }
    }
}
