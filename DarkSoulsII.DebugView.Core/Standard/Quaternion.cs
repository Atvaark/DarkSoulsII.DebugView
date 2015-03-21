namespace DarkSoulsII.DebugView.Core.Standard
{
    public class Quaternion : IReadable<Quaternion>
    {
        public float W { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public Quaternion Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            float[] data = reader.ReadSingle(4, address + 0x0000, relative);
            Z = data[0];
            Y = data[1];
            X = data[2];
            W = data[3];
            return this;
        }
    }
}
