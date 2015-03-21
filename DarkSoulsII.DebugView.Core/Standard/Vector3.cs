namespace DarkSoulsII.DebugView.Core.Standard
{
    public class Vector3 : IReadable<Vector3>
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Vector3 Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            float[] data = reader.ReadSingle(3, address, relative);
            X = data[0];
            Y = data[1];
            Z = data[2];
            return this;
        }

        public override string ToString()
        {
            return X + " " + Y + " " + Z;
        }
    }
}
