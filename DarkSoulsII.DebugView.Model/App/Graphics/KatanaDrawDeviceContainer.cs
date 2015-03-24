using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.App.Graphics
{
    public class KatanaDrawDeviceContainer : IReadable<KatanaDrawDeviceContainer>
    {
        public DrawDevice DrawDevice { get; set; }

        public KatanaDrawDeviceContainer Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            DrawDevice = pointerFactory.Create<DrawDevice>(address + 0x0138, relative).Unbox(pointerFactory, reader);
            return this;
        }
    }
}
