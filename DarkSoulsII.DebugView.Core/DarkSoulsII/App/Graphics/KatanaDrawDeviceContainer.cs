namespace DarkSoulsII.DebugView.Core.DarkSoulsII.App.Graphics
{
    public class KatanaDrawDeviceContainer : IReadable<KatanaDrawDeviceContainer>
    {
        public DrawDevice DrawDevice { get; set; }

        public KatanaDrawDeviceContainer Read(IReader reader, int address, bool relative = false)
        {
            DrawDevice = Pointer<DrawDevice>.CreateAndUnbox(reader, address + 0x0138, relative);
            return this;
        }
    }
}
