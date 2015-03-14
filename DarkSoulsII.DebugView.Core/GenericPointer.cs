using System;
using DarkSoulsII.DebugView.Core.Exceptions;

namespace DarkSoulsII.DebugView.Core
{
    public class GenericPointer
    {
        private GenericPointer()
        {
        }

        public int Address { get; set; }

        public bool IsNull
        {
            get { return Address == 0; }
        }

        public static GenericPointer Create(int address)
        {
            var pointer = new GenericPointer {Address = address};
            return pointer;
        }

        public static GenericPointer Create(IReader reader, int address, bool relative)
        {
            // TODO: Add a method to create a GenericPointer to the IPointerFactory interface.
            var pointer = new GenericPointer {Address = reader.ReadInt32(address, relative)};
            return pointer;
        }

        public void Unbox(IReader reader, Action<IReader, int> unboxAction)
        {
            unboxAction(reader, Address);
        }

        public bool TryUnbox(IReader reader, Action<IReader, int> unboxAction)
        {
            try
            {
                Unbox(reader, unboxAction);
                return true;
            }
            catch (MemoryInaccessibleException)
            {
                return false;
            }
        }

        public T Unbox<T>(IReader reader, Func<IReader, int, T> unboxAction)
        {
            return unboxAction(reader, Address);
        }

        public bool TryUnbox<T>(IReader reader, Func<IReader, int, T> unboxAction, out T output)
        {
            try
            {
                output = Unbox(reader, unboxAction);
                return true;
            }
            catch (MemoryInaccessibleException)
            {
                output = default(T);
                return false;
            }
        }
    }
}
