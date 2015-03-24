using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Sign
{
    public class SignSetCommonCtrl<T> : IReadable<SignSetCommonCtrl<T>> where T : class, IReadable<T>, IFixedSize, new()
    {
        public SignSet<T> SignSet1 { get; set; }
        public SignSet<T> SignSet2 { get; set; }

        public SignSetCommonCtrl<T> Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            SignSet1 = pointerFactory.Create<SignSet<T>>(address + 0x000C, relative).Unbox(pointerFactory, reader);
            SignSet2 = pointerFactory.Create<SignSet<T>>(address + 0x0010, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}