namespace DarkSoulsII.DebugView.Core.Standard
{
    public class Vector3 : IReadable<Vector3>
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Vector3 Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            X = reader.ReadSingle(address + 0x0000, relative);
            Y = reader.ReadSingle(address + 0x0004, relative);
            Z = reader.ReadSingle(address + 0x0008, relative);
            return this;
        }

        public override string ToString()
        {
            return X + " " + Y + " " + Z;
        }
    }
}
