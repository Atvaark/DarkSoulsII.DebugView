using DarkSoulsII.DebugView.Core.DarkSoulsII.App.Graphics;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.App
{
    public class KatanaMainApp : MainApp, IReadable<KatanaMainApp>
    {
        public KatanaDrawDeviceContainer DrawDeviceContainer { get; set; }
        public KatanaDrawSystem DrawSystem { get; set; }

        public new KatanaMainApp Read(IReader reader, int address, bool relative = false)
        {
            base.Read(reader, address, relative);
            DrawDeviceContainer = Pointer<KatanaDrawDeviceContainer>.CreateAndUnbox(reader, address + 0x002C, relative);
            DrawSystem = Pointer<KatanaDrawSystem>.CreateAndUnbox(reader, address + 0x01AC, relative);
            return this;
        }
    }
}
