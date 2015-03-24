using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Sign;

namespace DarkSoulsII.DebugView.Model.Managers.Sign
{
    public class SignManager : IReadable<SignManager>
    {
        public bool Initialized { get; set; }
        public ActiveSignManager ActiveSignManager { get; set; }
        public SignSetCtrlManager SignSetCtrlManager { get; set; }
        public SignPreviewCtrl SignPreviewCtrl { get; set; }
        public SignEventAreaManager SignEventAreaManager { get; set; }

        public SignManager Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            Initialized = reader.ReadBoolean(address + 0x0008, relative);
            SignSetCtrlManager = pointerFactory.Create<SignSetCtrlManager>(address + 0x0034, relative).Unbox(pointerFactory, reader);
            ActiveSignManager = pointerFactory.Create<ActiveSignManager>(address + 0x0038, relative).Unbox(pointerFactory, reader);
            SignPreviewCtrl = pointerFactory.Create<SignPreviewCtrl>(address + 0x003C, relative).Unbox(pointerFactory, reader);
            SignEventAreaManager = pointerFactory.Create<SignEventAreaManager>(address + 0x0040, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
