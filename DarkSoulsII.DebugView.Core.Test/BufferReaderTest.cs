using System;
using System.Linq;
using System.Text;
using DarkSoulsII.DebugView.Core.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DarkSoulsII.DebugView.Core.Test
{
    [TestClass]
    public class BufferReaderTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructurNullCheckTest()
        {
            byte[] bufferNull = null;
            const int baseAddress = 0;
            var bufferReader = new BufferReader(bufferNull, baseAddress);
            Assert.Fail();
        }

        [TestMethod]
        public void ConstructurTest()
        {
            byte[] bufferEmpty = { };
            byte[] buffer1 = { 0x00 };
            byte[] buffer2 = { 0x00, 0x01 };
            byte[] buffer3 = { 0x00, 0x01, 0x02 };
            byte[] buffer4 = { 0x00, 0x01, 0x02, 0x04 };

            const int baseAddress = 0;
            var bufferReader1 = new BufferReader(bufferEmpty, baseAddress);
            var bufferReader2 = new BufferReader(buffer1, baseAddress);
            var bufferReader3 = new BufferReader(buffer2, baseAddress);
            var bufferReader4 = new BufferReader(buffer3, baseAddress);
            var bufferReader5 = new BufferReader(buffer4, baseAddress);
        }

        [TestMethod]
        public void ReadTest()
        {
            byte[] buffer = 
            {
                0x00, 0x01, 0x02, 0x03,
                0x04, 0x05, 0x06, 0x07,
                0x08, 0x09, 0x0A, 0x0B,
            };
            const int baseAddress = 0;
            var bufferReader = new BufferReader(buffer, baseAddress);

            byte[] result0Offset0 = bufferReader.Read(0, 0);
            byte[] result1Offset0 = bufferReader.Read(1, 0);
            byte[] result2Offset0 = bufferReader.Read(2, 0);
            byte[] result3Offset0 = bufferReader.Read(3, 0);
            byte[] result4Offset0 = bufferReader.Read(4, 0);
            byte[] result5Offset0 = bufferReader.Read(5, 0);
            byte[] result6Offset0 = bufferReader.Read(6, 0);
            byte[] result6Offset1 = bufferReader.Read(6, 1);
            byte[] result6Offset2 = bufferReader.Read(6, 2);
            byte[] result6Offset3 = bufferReader.Read(6, 3);
            byte[] result6Offset4 = bufferReader.Read(6, 4);
            byte[] result6Offset5 = bufferReader.Read(6, 5);
            byte[] result6Offset6 = bufferReader.Read(6, 6);

            CollectionAssert.AreEqual(new byte[0], result0Offset0);
            CollectionAssert.AreEqual(new byte[] { 0x00 }, result1Offset0);
            CollectionAssert.AreEqual(new byte[] { 0x00, 0x01 }, result2Offset0);
            CollectionAssert.AreEqual(new byte[] { 0x00, 0x01, 0x02 }, result3Offset0);
            CollectionAssert.AreEqual(new byte[] { 0x00, 0x01, 0x02, 0x03 }, result4Offset0);
            CollectionAssert.AreEqual(new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04 }, result5Offset0);
            CollectionAssert.AreEqual(new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05 }, result6Offset0);

            CollectionAssert.AreEqual(new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06 }, result6Offset1);
            CollectionAssert.AreEqual(new byte[] { 0x02, 0x03, 0x04, 0x05, 0x06, 0x07 }, result6Offset2);
            CollectionAssert.AreEqual(new byte[] { 0x03, 0x04, 0x05, 0x06, 0x07, 0x08 }, result6Offset3);
            CollectionAssert.AreEqual(new byte[] { 0x04, 0x05, 0x06, 0x07, 0x08, 0x09 }, result6Offset4);
            CollectionAssert.AreEqual(new byte[] { 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A }, result6Offset5);
            CollectionAssert.AreEqual(new byte[] { 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B }, result6Offset6);
        }


        [TestMethod]
        public void ReadBooleanTest()
        {
            byte[] falseBuffer = 
            {
                0x00
            };
            byte[] trueBuffer1 = 
            {
                0x01
            };
            byte[] trueBuffer2 = 
            {
                0x02
            };

            const int baseAddress = 0;
            var bufferReader1 = new BufferReader(falseBuffer, baseAddress);
            var bufferReader2 = new BufferReader(trueBuffer1, baseAddress);
            var bufferReader3 = new BufferReader(trueBuffer2, baseAddress);

            var result1 = bufferReader1.ReadBoolean(0);
            var result2 = bufferReader2.ReadBoolean(0);
            var result3 = bufferReader3.ReadBoolean(0);

            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
            Assert.IsTrue(result3);
        }


        [TestMethod]
        public void ReadBooleanOffsetTest()
        {
            byte[] buffer = 
            {
                0x03, 0x00, 0x04, 0x00, 0x05
            };
            const int baseAddress = 0;
            var bufferReader = new BufferReader(buffer, baseAddress);

            var result0 = bufferReader.ReadBoolean(0);
            var result1 = bufferReader.ReadBoolean(1);
            var result2 = bufferReader.ReadBoolean(2);
            var result3 = bufferReader.ReadBoolean(3);
            var result4 = bufferReader.ReadBoolean(4);

            Assert.IsTrue(result0);
            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
            Assert.IsTrue(result4);
        }

        [TestMethod]
        public void ReadInt32Test()
        {
            byte[] buffer0 = BitConverter.GetBytes(0);
            byte[] buffer1 = BitConverter.GetBytes(1);
            byte[] buffer2 = BitConverter.GetBytes(2);
            byte[] buffer123 = BitConverter.GetBytes(123);
            byte[] buffer255 = BitConverter.GetBytes(255);
            byte[] buffer5000 = BitConverter.GetBytes(5000);
            byte[] buffer252645135 = BitConverter.GetBytes(252645135);
            byte[] buffer1431655765 = BitConverter.GetBytes(1431655765);

            const int baseAddress = 0;
            var bufferReader0 = new BufferReader(buffer0, baseAddress);
            var bufferReader1 = new BufferReader(buffer1, baseAddress);
            var bufferReader2 = new BufferReader(buffer2, baseAddress);
            var bufferReader123 = new BufferReader(buffer123, baseAddress);
            var bufferReader255 = new BufferReader(buffer255, baseAddress);
            var bufferReader5000 = new BufferReader(buffer5000, baseAddress);
            var bufferReader252645135 = new BufferReader(buffer252645135, baseAddress);
            var bufferReader1431655765 = new BufferReader(buffer1431655765, baseAddress);

            var result0 = bufferReader0.ReadInt32(0);
            var result1 = bufferReader1.ReadInt32(0);
            var result2 = bufferReader2.ReadInt32(0);
            var result123 = bufferReader123.ReadInt32(0);
            var result255 = bufferReader255.ReadInt32(0);
            var result5000 = bufferReader5000.ReadInt32(0);
            var result252645135 = bufferReader252645135.ReadInt32(0);
            var result1431655765 = bufferReader1431655765.ReadInt32(0);

            Assert.AreEqual(0, result0);
            Assert.AreEqual(1, result1);
            Assert.AreEqual(2, result2);
            Assert.AreEqual(123, result123);
            Assert.AreEqual(255, result255);
            Assert.AreEqual(5000, result5000);
            Assert.AreEqual(252645135, result252645135);
            Assert.AreEqual(1431655765, result1431655765);
        }


        [TestMethod]
        public void ReadAnsiCharTest()
        {
            byte[] buffer = Encoding.ASCII.GetBytes("This is a test ansi string\t\n");
            const int baseAddress = 0;

            var bufferReader = new BufferReader(buffer, baseAddress);

            var result0 = bufferReader.ReadAnsiChar(0);
            var result1 = bufferReader.ReadAnsiChar(1);
            var result2 = bufferReader.ReadAnsiChar(2);
            var result3 = bufferReader.ReadAnsiChar(3);
            var result4 = bufferReader.ReadAnsiChar(4);
            var result26 = bufferReader.ReadAnsiChar(26);
            var result27 = bufferReader.ReadAnsiChar(27);

            Assert.AreEqual('T', result0);
            Assert.AreEqual('h', result1);
            Assert.AreEqual('i', result2);
            Assert.AreEqual('s', result3);
            Assert.AreEqual(' ', result4);
            Assert.AreEqual('\t', result26);
            Assert.AreEqual('\n', result27);
        }

        [TestMethod]
        public void ReadUnicodeCharLatinTest()
        {
            byte[] buffer1 = Encoding.Unicode.GetBytes("This is a test unicode string\t\n");
            const int baseAddress = 0;

            var bufferReader = new BufferReader(buffer1, baseAddress);

            var bufferReaderresult0 = bufferReader.ReadUnicodeChar(0);
            var bufferReaderresult2 = bufferReader.ReadUnicodeChar(2);
            var bufferReaderresult8 = bufferReader.ReadUnicodeChar(8);
            var bufferReaderresult58 = bufferReader.ReadUnicodeChar(58);
            var bufferReaderresult60 = bufferReader.ReadUnicodeChar(60);
            
            Assert.AreEqual('T', bufferReaderresult0);
            Assert.AreEqual('h', bufferReaderresult2);
            Assert.AreEqual(' ', bufferReaderresult8);
            Assert.AreEqual('\t', bufferReaderresult58);
            Assert.AreEqual('\n', bufferReaderresult60);
        }

        [TestMethod]
        public void ReadUnicodeCharJapaneseTest()
        {
            byte[] buffer = Encoding.Unicode.GetBytes("セーブデータリスト用");
            const int baseAddress = 0;

            var bufferReader = new BufferReader(buffer, baseAddress);

            var bufferReaderresult0 = bufferReader.ReadUnicodeChar(0);
            var bufferReaderresult2 = bufferReader.ReadUnicodeChar(2);
            var bufferReaderresult4 = bufferReader.ReadUnicodeChar(4);
            var bufferReaderresult18 = bufferReader.ReadUnicodeChar(18);

            Assert.AreEqual('セ', bufferReaderresult0);
            Assert.AreEqual('ー', bufferReaderresult2);
            Assert.AreEqual('ブ', bufferReaderresult4);
            Assert.AreEqual('用', bufferReaderresult18);
        }
        
        [TestMethod]
        public void ReadAnsiStringTest()
        {
            byte[] buffer = Encoding.ASCII.GetBytes("This is a test ansi string\t\n");
            const int baseAddress = 0;

            var bufferReader = new BufferReader(buffer, baseAddress);

            var result0Offset0 = bufferReader.ReadAnsiString(0, 0);
            var result1Offset0 = bufferReader.ReadAnsiString(1, 0);
            var result2Offset0 = bufferReader.ReadAnsiString(2, 0);
            var result5Offset0 = bufferReader.ReadAnsiString(5, 0);
            var result28Offset0 = bufferReader.ReadAnsiString(28, 0);
            var result0Offset1 = bufferReader.ReadAnsiString(0, 1);
            var result1Offset2 = bufferReader.ReadAnsiString(1, 2);
            var result2Offset3 = bufferReader.ReadAnsiString(2, 3);
            var result5Offset4 = bufferReader.ReadAnsiString(5, 4);
            
            Assert.AreEqual("", result0Offset0);
            Assert.AreEqual("T", result1Offset0);
            Assert.AreEqual("Th", result2Offset0);
            Assert.AreEqual("This ", result5Offset0);
            Assert.AreEqual("This is a test ansi string\t\n", result28Offset0);
            Assert.AreEqual("", result0Offset1);
            Assert.AreEqual("i", result1Offset2);
            Assert.AreEqual("s ", result2Offset3);
            Assert.AreEqual(" is a", result5Offset4);
        }

        [TestMethod]
        public void ReadUnicodeStringLatinTest()
        {
            byte[] buffer1 = Encoding.Unicode.GetBytes("This is a test unicode string\t\n");
            const int baseAddress = 0;

            var bufferReader1 = new BufferReader(buffer1, baseAddress);

            var result0Offset0 = bufferReader1.ReadUnicodeString(0, 0);
            var result1Offset0 = bufferReader1.ReadUnicodeString(1, 0);
            var result2Offset0 = bufferReader1.ReadUnicodeString(2, 0);
            var result5Offset0 = bufferReader1.ReadUnicodeString(5, 0);
            var result28Offset0 = bufferReader1.ReadUnicodeString(31, 0);
            var result0Offset2 = bufferReader1.ReadUnicodeString(0, 2);
            var result1Offset4 = bufferReader1.ReadUnicodeString(1, 4);
            var result2Offset6 = bufferReader1.ReadUnicodeString(2, 6);
            var result5Offset8 = bufferReader1.ReadUnicodeString(5, 8);

            Assert.AreEqual("", result0Offset0);
            Assert.AreEqual("T", result1Offset0);
            Assert.AreEqual("Th", result2Offset0);
            Assert.AreEqual("This ", result5Offset0);
            Assert.AreEqual("This is a test unicode string\t\n", result28Offset0);
            Assert.AreEqual("", result0Offset2);
            Assert.AreEqual("i", result1Offset4);
            Assert.AreEqual("s ", result2Offset6);
            Assert.AreEqual(" is a", result5Offset8);
        }
        
        [TestMethod]
        public void ReadUnicodeStringJapaneseTest()
        {
            byte[] buffer = Encoding.Unicode.GetBytes("セーブデータリスト用");
            const int baseAddress = 0;

            var bufferReader = new BufferReader(buffer, baseAddress);
            var result0Offset0 = bufferReader.ReadUnicodeString(0, 0);
            var result1Offset0 = bufferReader.ReadUnicodeString(1, 0);
            var result2Offset0 = bufferReader.ReadUnicodeString(2, 0);
            var result5Offset0 = bufferReader.ReadUnicodeString(5, 0);
            var result0Offset2 = bufferReader.ReadUnicodeString(0, 2);
            var result1Offset4 = bufferReader.ReadUnicodeString(1, 4);
            var result2Offset6 = bufferReader.ReadUnicodeString(2, 6);
            var result5Offset8 = bufferReader.ReadUnicodeString(5, 8);

            Assert.AreEqual("", result0Offset0);
            Assert.AreEqual("セ", result1Offset0);
            Assert.AreEqual("セー", result2Offset0);
            Assert.AreEqual("セーブデー", result5Offset0);
            Assert.AreEqual("", result0Offset2);
            Assert.AreEqual("ブ", result1Offset4);
            Assert.AreEqual("デー", result2Offset6);
            Assert.AreEqual("ータリスト", result5Offset8);
        }

        [TestMethod]
        public void ReadNullTerminatedAnsiStringLatinTest()
        {
            byte[] buffer = Encoding.ASCII.GetBytes("This string is null terminated.\0This one too!\0");
            const int baseAddress = 0;

            var bufferReader = new BufferReader(buffer, baseAddress);
            var result0 = bufferReader.ReadNullTerminatedAnsiString(0, false);
            var result1 = bufferReader.ReadNullTerminatedAnsiString(1, false);
            var result5 = bufferReader.ReadNullTerminatedAnsiString(5, false);
            var result31 = bufferReader.ReadNullTerminatedAnsiString(31, false);
            var result32 = bufferReader.ReadNullTerminatedAnsiString(32, false);
            var result33 = bufferReader.ReadNullTerminatedAnsiString(33, false);

            Assert.AreEqual("This string is null terminated.", result0);
            Assert.AreEqual("his string is null terminated.", result1);
            Assert.AreEqual("string is null terminated.", result5);
            Assert.AreEqual("", result31);
            Assert.AreEqual("This one too!", result32);
            Assert.AreEqual("his one too!", result33);
        }

        [TestMethod]
        public void ReadNullTerminatedUnicodeStringLatinTest()
        {
            byte[] buffer = Encoding.Unicode.GetBytes("This string is null terminated.\0This one too!\0");
            const int baseAddress = 0;

            var bufferReader = new BufferReader(buffer, baseAddress);
            var result0 = bufferReader.ReadNullTerminatedUnicodeString(0, false);
            var result1 = bufferReader.ReadNullTerminatedUnicodeString(2, false);
            var result5 = bufferReader.ReadNullTerminatedUnicodeString(10, false);
            var result31 = bufferReader.ReadNullTerminatedUnicodeString(62, false);
            var result32 = bufferReader.ReadNullTerminatedUnicodeString(64, false);
            var result33 = bufferReader.ReadNullTerminatedUnicodeString(66, false);

            Assert.AreEqual("This string is null terminated.", result0);
            Assert.AreEqual("his string is null terminated.", result1);
            Assert.AreEqual("string is null terminated.", result5);
            Assert.AreEqual("", result31);
            Assert.AreEqual("This one too!", result32);
            Assert.AreEqual("his one too!", result33);
        }

        [TestMethod]
        public void ReadNullTerminatedUnicodeStringJapaneseTest()
        {
            byte[] buffer = Encoding.Unicode.GetBytes("セーブ\0データ\0リスト\0用\0");
            const int baseAddress = 0;

            var bufferReader = new BufferReader(buffer, baseAddress);
            var result0 = bufferReader.ReadNullTerminatedUnicodeString(0, false);
            var result2 = bufferReader.ReadNullTerminatedUnicodeString(2, false);
            var result4 = bufferReader.ReadNullTerminatedUnicodeString(4, false);
            var result6 = bufferReader.ReadNullTerminatedUnicodeString(6, false);
            var result8 = bufferReader.ReadNullTerminatedUnicodeString(8, false);
            var result10 = bufferReader.ReadNullTerminatedUnicodeString(10, false);
            var result12 = bufferReader.ReadNullTerminatedUnicodeString(12, false);
            var result14 = bufferReader.ReadNullTerminatedUnicodeString(14, false);
            var result16 = bufferReader.ReadNullTerminatedUnicodeString(16, false);
            var result18 = bufferReader.ReadNullTerminatedUnicodeString(18, false);
            var result20 = bufferReader.ReadNullTerminatedUnicodeString(20, false);
            var result22 = bufferReader.ReadNullTerminatedUnicodeString(22, false);
            var result24 = bufferReader.ReadNullTerminatedUnicodeString(24, false);
            var result26 = bufferReader.ReadNullTerminatedUnicodeString(26, false);

            Assert.AreEqual("セーブ", result0);
            Assert.AreEqual("ーブ", result2);
            Assert.AreEqual("ブ", result4);
            Assert.AreEqual("", result6);
            Assert.AreEqual("データ", result8);
            Assert.AreEqual("ータ", result10);
            Assert.AreEqual("タ", result12);
            Assert.AreEqual("", result14);
            Assert.AreEqual("リスト", result16);
            Assert.AreEqual("スト", result18);
            Assert.AreEqual("ト", result20);
            Assert.AreEqual("", result22);
            Assert.AreEqual("用", result24);
            Assert.AreEqual("", result26);
        }


        [TestMethod]
        public void ReadNullTerminatedAnsiStringChunkedLatinTest()
        {
            byte[] buffer = Encoding.ASCII.GetBytes("This string is null terminated.\0This one too!\0")
                .Concat(Enumerable.Repeat((byte)0x00, 16))
                .ToArray();
            const int baseAddress = 0;

            var bufferReader = new BufferReader(buffer, baseAddress);
            var result0 = bufferReader.ReadNullTerminatedAnsiStringChunked(16, 0, false);
            var result1 = bufferReader.ReadNullTerminatedAnsiStringChunked(16, 1, false);
            var result5 = bufferReader.ReadNullTerminatedAnsiStringChunked(16, 5, false);
            var result31 = bufferReader.ReadNullTerminatedAnsiStringChunked(16, 31, false);
            var result32 = bufferReader.ReadNullTerminatedAnsiStringChunked(16, 32, false);
            var result33 = bufferReader.ReadNullTerminatedAnsiStringChunked(16, 33, false);

            Assert.AreEqual("This string is null terminated.", result0);
            Assert.AreEqual("his string is null terminated.", result1);
            Assert.AreEqual("string is null terminated.", result5);
            Assert.AreEqual("", result31);
            Assert.AreEqual("This one too!", result32);
            Assert.AreEqual("his one too!", result33);
        }

        [TestMethod]
        public void ReadNullTerminatedUnicodeStringChunkedLatinTest()
        {
            byte[] buffer = Encoding.Unicode.GetBytes("This string is null terminated.\0This one too!\0")
                .Concat(Enumerable.Repeat((byte)0x00, 32))
                .ToArray();
            const int baseAddress = 0;

            var bufferReader = new BufferReader(buffer, baseAddress);
            var result0 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 0, false);
            var result1 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 2, false);
            var result5 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 10, false);
            var result31 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 62, false);
            var result32 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 64, false);
            var result33 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 66, false);

            Assert.AreEqual("This string is null terminated.", result0);
            Assert.AreEqual("his string is null terminated.", result1);
            Assert.AreEqual("string is null terminated.", result5);
            Assert.AreEqual("", result31);
            Assert.AreEqual("This one too!", result32);
            Assert.AreEqual("his one too!", result33);
        }

        [TestMethod]
        public void ReadNullTerminatedUnicodeStringChunkedJapaneseTest()
        {
            byte[] buffer = Encoding.Unicode.GetBytes("セーブ\0データ\0リスト\0用\0")
                .Concat(Enumerable.Repeat((byte)0x00, 32))
                .ToArray();
            const int baseAddress = 0;

            var bufferReader = new BufferReader(buffer, baseAddress);
            var result0 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 0, false);
            var result2 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 2, false);
            var result4 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 4, false);
            var result6 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 6, false);
            var result8 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 8, false);
            var result10 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 10, false);
            var result12 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 12, false);
            var result14 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 14, false);
            var result16 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 16, false);
            var result18 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 18, false);
            var result20 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 20, false);
            var result22 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 22, false);
            var result24 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 24, false);
            var result26 = bufferReader.ReadNullTerminatedUnicodeStringChunked(16, 26, false);

            Assert.AreEqual("セーブ", result0);
            Assert.AreEqual("ーブ", result2);
            Assert.AreEqual("ブ", result4);
            Assert.AreEqual("", result6);
            Assert.AreEqual("データ", result8);
            Assert.AreEqual("ータ", result10);
            Assert.AreEqual("タ", result12);
            Assert.AreEqual("", result14);
            Assert.AreEqual("リスト", result16);
            Assert.AreEqual("スト", result18);
            Assert.AreEqual("ト", result20);
            Assert.AreEqual("", result22);
            Assert.AreEqual("用", result24);
            Assert.AreEqual("", result26);
        }
    }
}
