namespace DarkSoulsII.DebugView.Core.Standard
{
    public class Matrix4 : IReadable<Matrix4>
    {
        public static readonly Matrix4 Identity = new Matrix4
            (
            1f, 0f, 0f, 0f,
            0f, 1f, 0f, 0f,
            0f, 0f, 1f, 0f,
            0f, 0f, 0f, 1f
            );

        public float M11;
        public float M12;
        public float M13;
        public float M14;
        public float M21;
        public float M22;
        public float M23;
        public float M24;
        public float M31;
        public float M32;
        public float M33;
        public float M34;
        public float M41;
        public float M42;
        public float M43;
        public float M44;

        public Matrix4()
        {
        }

        public Matrix4(float m11, float m12, float m13, float m14,
            float m21, float m22, float m23, float m24,
            float m31, float m32, float m33, float m34,
            float m41, float m42, float m43, float m44)
        {
            M11 = m11;
            M12 = m12;
            M13 = m13;
            M14 = m14;
            M21 = m21;
            M22 = m22;
            M23 = m23;
            M24 = m24;
            M31 = m31;
            M32 = m32;
            M33 = m33;
            M34 = m34;
            M41 = m41;
            M42 = m42;
            M43 = m43;
            M44 = m44;
        }


        public Matrix4 Read(IReader reader, int address, bool relative = false)
        {
            float[] data = reader.ReadSingle(16, address, relative);

            M11 = data[0];
            M12 = data[1];
            M13 = data[2];
            M14 = data[3];
            M21 = data[4];
            M22 = data[5];
            M23 = data[6];
            M24 = data[7];
            M31 = data[8];
            M32 = data[9];
            M33 = data[10];
            M34 = data[11];
            M41 = data[12];
            M42 = data[13];
            M43 = data[14];
            M44 = data[15];

            return this;
        }

        public override string ToString()
        {
            return string.Format("M11: {0}, M12: {1}, M13: {2}, M14: {3}, " +
                                 "M21: {4}, M22: {5}, M23: {6}, M24: {7}, " +
                                 "M31: {8}, M32: {9}, M33: {10}, M34: {11}, " +
                                 "M41: {12}, M42: {13}, M43: {14}, M44: {15}",
                M11, M12, M13, M14,
                M21, M22, M23, M24,
                M31, M32, M33, M34,
                M41, M42, M43, M44);
        }
    }
}
