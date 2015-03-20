namespace DarkSoulsII.DebugView.Core
{
    public interface IReader
    {
        byte[] Read(int size, int address, bool relative = false);
        bool ReadBoolean(int address, bool relative = false);
        byte ReadByte(int address, bool relative = false);
        sbyte ReadSByte(int address, bool relative = false);
        short ReadInt16(int address, bool relative = false);
        ushort ReadUInt16(int address, bool relative = false);
        int ReadInt32(int address, bool relative = false);
        int[] ReadInt32(int count, int address, bool relative = false);
        uint ReadUInt32(int address, bool relative = false);
        long ReadInt64(int address, bool relative = false);
        ulong ReadUInt64(int address, bool relative = false);
        float ReadSingle(int address, bool relative = false);
        float[] ReadSingle(int count, int address, bool relative = false);
        double ReadDouble(int address, bool relative = false);
        decimal ReadDecimal(int address, bool relative = false);
        char ReadAnsiChar(int address, bool relative = false);
        char ReadUnicodeChar(int address, bool relative = false);
        string ReadAnsiString(int length, int address, bool relative = false);
        string ReadUnicodeString(int length, int address, bool relative = false);
        string ReadNullTerminatedAnsiString(int address, bool relative);
        string ReadNullTerminatedUnicodeString(int address, bool relative);
        string ReadNullTerminatedAnsiStringChunked(int lookaheadCharCount, int address, bool relative);
        string ReadNullTerminatedUnicodeStringChunked(int lookaheadCharCount, int address, bool relative);
    }
}
