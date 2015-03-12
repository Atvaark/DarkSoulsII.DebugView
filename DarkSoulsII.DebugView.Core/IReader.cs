using System;
using System.Text;

namespace DarkSoulsII.DebugView.Core
{
    public interface IReader
    {
        byte[] Read(int size, int address, bool relative = false);
        bool ReadBoolean(int address, bool relative = false);
        byte ReadByte(int address, bool relative = false);
        SByte ReadSByte(int address, bool relative = false);
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
        char ReadChar(int address, bool relative = false);
        char ReadChar(int charSize, Encoding encoding, int address, bool relative = false);
        string ReadString(int length, int address, bool relative = false);
        string ReadString(int length, int charSize, Encoding encoding, int address, bool relative = false);
        string ReadNullTerminatedString(int address, bool relative);
        string ReadNullTerminatedString(Encoding encoding, int charSize, int address, bool relative);
        string ReadNullTerminatedStringChunked(int address, bool relative);
        string ReadNullTerminatedStringChunked(int lookaheadCharCount, int address, bool relative);

        string ReadNullTerminatedStringChunked(Encoding encoding, int charSize, int lookaheadCharCount, int address,
            bool relative);
    }
}
