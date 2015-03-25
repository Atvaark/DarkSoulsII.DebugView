using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DarkSoulsII.DebugView.Core.Test
{
    [TestClass]
    public class MemoryReaderTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructurNullCheckTest()
        {
            byte[] bufferNull = null;
            const int baseAddress = 0;
            var memoryReader = new MemoryReader(bufferNull, baseAddress);
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
            var memoryReader1 = new MemoryReader(bufferEmpty, baseAddress);
            var memoryReader2 = new MemoryReader(buffer1, baseAddress);
            var memoryReader3 = new MemoryReader(buffer2, baseAddress);
            var memoryReader4 = new MemoryReader(buffer3, baseAddress);
            var memoryReader5 = new MemoryReader(buffer4, baseAddress);
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
            var memoryReader = new MemoryReader(buffer, baseAddress);

            byte[] result0Offset0 = memoryReader.Read(0, 0);
            byte[] result1Offset0 = memoryReader.Read(1, 0);
            byte[] result2Offset0 = memoryReader.Read(2, 0);
            byte[] result3Offset0 = memoryReader.Read(3, 0);
            byte[] result4Offset0 = memoryReader.Read(4, 0);
            byte[] result5Offset0 = memoryReader.Read(5, 0);
            byte[] result6Offset0 = memoryReader.Read(6, 0);
            byte[] result6Offset1 = memoryReader.Read(6, 1);
            byte[] result6Offset2 = memoryReader.Read(6, 2);
            byte[] result6Offset3 = memoryReader.Read(6, 3);
            byte[] result6Offset4 = memoryReader.Read(6, 4);
            byte[] result6Offset5 = memoryReader.Read(6, 5);
            byte[] result6Offset6 = memoryReader.Read(6, 6);

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
            var memoryReader1 = new MemoryReader(falseBuffer, baseAddress);
            var memoryReader2 = new MemoryReader(trueBuffer1, baseAddress);
            var memoryReader3 = new MemoryReader(trueBuffer2, baseAddress);

            var result1 = memoryReader1.ReadBoolean(0);
            var result2 = memoryReader2.ReadBoolean(0);
            var result3 = memoryReader3.ReadBoolean(0);

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
            var memoryReader = new MemoryReader(buffer, baseAddress);

            var result0 = memoryReader.ReadBoolean(0);
            var result1 = memoryReader.ReadBoolean(1);
            var result2 = memoryReader.ReadBoolean(2);
            var result3 = memoryReader.ReadBoolean(3);
            var result4 = memoryReader.ReadBoolean(4);

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
            var memoryReader0 = new MemoryReader(buffer0, baseAddress);
            var memoryReader1 = new MemoryReader(buffer1, baseAddress);
            var memoryReader2 = new MemoryReader(buffer2, baseAddress);
            var memoryReader123 = new MemoryReader(buffer123, baseAddress);
            var memoryReader255 = new MemoryReader(buffer255, baseAddress);
            var memoryReader5000 = new MemoryReader(buffer5000, baseAddress);
            var memoryReader252645135 = new MemoryReader(buffer252645135, baseAddress);
            var memoryReader1431655765 = new MemoryReader(buffer1431655765, baseAddress);

            var result0 = memoryReader0.ReadInt32(0);
            var result1 = memoryReader1.ReadInt32(0);
            var result2 = memoryReader2.ReadInt32(0);
            var result123 = memoryReader123.ReadInt32(0);
            var result255 = memoryReader255.ReadInt32(0);
            var result5000 = memoryReader5000.ReadInt32(0);
            var result252645135 = memoryReader252645135.ReadInt32(0);
            var result1431655765 = memoryReader1431655765.ReadInt32(0);

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

            var memoryReader = new MemoryReader(buffer, baseAddress);

            var result0 = memoryReader.ReadAnsiChar(0);
            var result1 = memoryReader.ReadAnsiChar(1);
            var result2 = memoryReader.ReadAnsiChar(2);
            var result3 = memoryReader.ReadAnsiChar(3);
            var result4 = memoryReader.ReadAnsiChar(4);
            var result26 = memoryReader.ReadAnsiChar(26);
            var result27 = memoryReader.ReadAnsiChar(27);

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

            var memoryReader = new MemoryReader(buffer1, baseAddress);

            var memoryReaderresult0 = memoryReader.ReadUnicodeChar(0);
            var memoryReaderresult2 = memoryReader.ReadUnicodeChar(2);
            var memoryReaderresult8 = memoryReader.ReadUnicodeChar(8);
            var memoryReaderresult58 = memoryReader.ReadUnicodeChar(58);
            var memoryReaderresult60 = memoryReader.ReadUnicodeChar(60);
            
            Assert.AreEqual('T', memoryReaderresult0);
            Assert.AreEqual('h', memoryReaderresult2);
            Assert.AreEqual(' ', memoryReaderresult8);
            Assert.AreEqual('\t', memoryReaderresult58);
            Assert.AreEqual('\n', memoryReaderresult60);
        }

        [TestMethod]
        public void ReadUnicodeCharJapaneseTest()
        {
            byte[] buffer = Encoding.Unicode.GetBytes("セーブデータリスト用");
            const int baseAddress = 0;

            var memoryReader = new MemoryReader(buffer, baseAddress);

            var memoryReaderresult0 = memoryReader.ReadUnicodeChar(0);
            var memoryReaderresult2 = memoryReader.ReadUnicodeChar(2);
            var memoryReaderresult4 = memoryReader.ReadUnicodeChar(4);
            var memoryReaderresult18 = memoryReader.ReadUnicodeChar(18);

            Assert.AreEqual('セ', memoryReaderresult0);
            Assert.AreEqual('ー', memoryReaderresult2);
            Assert.AreEqual('ブ', memoryReaderresult4);
            Assert.AreEqual('用', memoryReaderresult18);
        }
        
        [TestMethod]
        public void ReadAnsiStringTest()
        {
            byte[] buffer = Encoding.ASCII.GetBytes("This is a test ansi string\t\n");
            const int baseAddress = 0;

            var memoryReader = new MemoryReader(buffer, baseAddress);

            var result0Offset0 = memoryReader.ReadAnsiString(0, 0);
            var result1Offset0 = memoryReader.ReadAnsiString(1, 0);
            var result2Offset0 = memoryReader.ReadAnsiString(2, 0);
            var result5Offset0 = memoryReader.ReadAnsiString(5, 0);
            var result28Offset0 = memoryReader.ReadAnsiString(28, 0);
            var result0Offset1 = memoryReader.ReadAnsiString(0, 1);
            var result1Offset2 = memoryReader.ReadAnsiString(1, 2);
            var result2Offset3 = memoryReader.ReadAnsiString(2, 3);
            var result5Offset4 = memoryReader.ReadAnsiString(5, 4);
            
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

            var memoryReader1 = new MemoryReader(buffer1, baseAddress);

            var result0Offset0 = memoryReader1.ReadUnicodeString(0, 0);
            var result1Offset0 = memoryReader1.ReadUnicodeString(1, 0);
            var result2Offset0 = memoryReader1.ReadUnicodeString(2, 0);
            var result5Offset0 = memoryReader1.ReadUnicodeString(5, 0);
            var result28Offset0 = memoryReader1.ReadUnicodeString(31, 0);
            var result0Offset2 = memoryReader1.ReadUnicodeString(0, 2);
            var result1Offset4 = memoryReader1.ReadUnicodeString(1, 4);
            var result2Offset6 = memoryReader1.ReadUnicodeString(2, 6);
            var result5Offset8 = memoryReader1.ReadUnicodeString(5, 8);

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

            var memoryReader = new MemoryReader(buffer, baseAddress);
            var result0Offset0 = memoryReader.ReadUnicodeString(0, 0);
            var result1Offset0 = memoryReader.ReadUnicodeString(1, 0);
            var result2Offset0 = memoryReader.ReadUnicodeString(2, 0);
            var result5Offset0 = memoryReader.ReadUnicodeString(5, 0);
            var result0Offset2 = memoryReader.ReadUnicodeString(0, 2);
            var result1Offset4 = memoryReader.ReadUnicodeString(1, 4);
            var result2Offset6 = memoryReader.ReadUnicodeString(2, 6);
            var result5Offset8 = memoryReader.ReadUnicodeString(5, 8);

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

            var memoryReader = new MemoryReader(buffer, baseAddress);
            var result0 = memoryReader.ReadNullTerminatedAnsiString(0, false);
            var result1 = memoryReader.ReadNullTerminatedAnsiString(1, false);
            var result5 = memoryReader.ReadNullTerminatedAnsiString(5, false);
            var result31 = memoryReader.ReadNullTerminatedAnsiString(31, false);
            var result32 = memoryReader.ReadNullTerminatedAnsiString(32, false);
            var result33 = memoryReader.ReadNullTerminatedAnsiString(33, false);

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

            var memoryReader = new MemoryReader(buffer, baseAddress);
            var result0 = memoryReader.ReadNullTerminatedUnicodeString(0, false);
            var result1 = memoryReader.ReadNullTerminatedUnicodeString(2, false);
            var result5 = memoryReader.ReadNullTerminatedUnicodeString(10, false);
            var result31 = memoryReader.ReadNullTerminatedUnicodeString(62, false);
            var result32 = memoryReader.ReadNullTerminatedUnicodeString(64, false);
            var result33 = memoryReader.ReadNullTerminatedUnicodeString(66, false);

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
            byte[] buffer = Encoding.Unicode.GetBytes("セーブ\0データ\0リスト\0用");
            const int baseAddress = 0;

            var memoryReader = new MemoryReader(buffer, baseAddress);
            var result0 = memoryReader.ReadNullTerminatedUnicodeString(0, false);
            var result2 = memoryReader.ReadNullTerminatedUnicodeString(2, false);
            var result4 = memoryReader.ReadNullTerminatedUnicodeString(4, false);
            var result6 = memoryReader.ReadNullTerminatedUnicodeString(6, false);
            var result8 = memoryReader.ReadNullTerminatedUnicodeString(8, false);
            var result10 = memoryReader.ReadNullTerminatedUnicodeString(10, false);
            var result12 = memoryReader.ReadNullTerminatedUnicodeString(12, false);
            var result14 = memoryReader.ReadNullTerminatedUnicodeString(14, false);
            var result16 = memoryReader.ReadNullTerminatedUnicodeString(16, false);
            var result18 = memoryReader.ReadNullTerminatedUnicodeString(18, false);
            var result20 = memoryReader.ReadNullTerminatedUnicodeString(20, false);
            var result22 = memoryReader.ReadNullTerminatedUnicodeString(22, false);
            var result24 = memoryReader.ReadNullTerminatedUnicodeString(24, false);
            var result26 = memoryReader.ReadNullTerminatedUnicodeString(26, false);

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
