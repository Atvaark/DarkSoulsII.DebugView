using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.App.Graphics;

namespace DarkSoulsII.DebugView.Model.App
{
    public class KatanaMainApp : MainApp, IReadable<KatanaMainApp>
    {
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public float SecondsPerTick { get; set; }
        public int TickCurrentSecond { get; set; }
        public float TickPerSecond { get; set; }
        public int Ticks { get; set; }

        public KatanaDrawDeviceContainer DrawDeviceContainer { get; set; }
        public KatanaDrawSystem DrawSystem { get; set; }

        public new KatanaMainApp Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);

            ScreenWidth = reader.ReadInt32(address + 0x001C, relative);
            ScreenHeight = reader.ReadInt32(address + 0x0020, relative);

            SecondsPerTick = reader.ReadSingle(address + 0x00A8, relative);
            TickCurrentSecond = reader.ReadInt32(address + 0x00B0, relative);
            TickPerSecond = reader.ReadSingle(address + 0x00C0, relative);
            Ticks = reader.ReadInt32(address + 0x0158, relative);

            DrawDeviceContainer = pointerFactory.Create<KatanaDrawDeviceContainer>(address + 0x002C, relative).Unbox(pointerFactory, reader);
            DrawSystem = pointerFactory.Create<KatanaDrawSystem>(address + 0x01AC, relative).Unbox(pointerFactory, reader);

            return this;
        }

    }
}
