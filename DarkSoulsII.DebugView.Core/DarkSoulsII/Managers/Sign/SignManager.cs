using DarkSoulsII.DebugView.Core.DarkSoulsII.Controllers;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Managers.Sign
{
    public class SignManager : IReadable<SignManager>
    {
        public bool Initialized { get; set; }
        public ActiveSignManager ActiveSignManager { get; set; }
        public SignSetCtrlManager SignSetCtrlManager { get; set; }
        public SignPreviewCtrl SignPreviewCtrl { get; set; }
        public SignEventAreaManager SignEventAreaManager { get; set; }

        public SignManager Read(IReader reader, int address, bool relative = false)
        {
            Initialized = reader.ReadBoolean(address + 0x0008, relative);
            SignSetCtrlManager = Pointer<SignSetCtrlManager>.CreateAndUnbox(reader, address + 0x0034, relative);
            ActiveSignManager = Pointer<ActiveSignManager>.CreateAndUnbox(reader, address + 0x0038, relative);
            SignPreviewCtrl = Pointer<SignPreviewCtrl>.CreateAndUnbox(reader, address + 0x003C, relative);
            SignEventAreaManager = Pointer<SignEventAreaManager>.CreateAndUnbox(reader, address + 0x0040, relative);

            return this;
        }
    }
}
