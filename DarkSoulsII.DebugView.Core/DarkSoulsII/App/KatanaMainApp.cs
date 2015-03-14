using DarkSoulsII.DebugView.Core.DarkSoulsII.App.Graphics;

namespace DarkSoulsII.DebugView.Core.DarkSoulsII.App
{
    public class KatanaMainApp : MainApp, IReadable<KatanaMainApp>
    {
        public KatanaDrawDeviceContainer DrawDeviceContainer { get; set; }
        public KatanaDrawSystem DrawSystem { get; set; }

        public new KatanaMainApp Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            DrawDeviceContainer = pointerFactory.Create<KatanaDrawDeviceContainer>(address + 0x002C, relative).Unbox(pointerFactory, reader);
            DrawSystem = pointerFactory.Create<KatanaDrawSystem>(address + 0x01AC, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
