using System;
using DarkSoulsII.DebugView.Core.Exceptions;

namespace DarkSoulsII.DebugView.Core
{
    // TODO: Add a PointerArray<T> class
    public class Pointer<T> : IReadable<Pointer<T>>, IPointer<T> where T : class, IReadable<T>, new()
    {
        public Pointer()
        {
        }

        private Pointer(int address)
        {
            Address = address;
        }

        private Pointer(int address, bool relative)
        {
            Address = address;
            Relative = relative;
        }

        public int Address { get; set; }
        public bool Relative { get; set; }

        public static int Size
        {
            get { return sizeof (int); }
        }

        public T Unbox(IReader reader)
        {
            if (Address == 0)
                return null;
            T obj = new T();
            return obj.Read(reader, Address, Relative);
        }

        public T TryUnbox(IReader reader)
        {
            try
            {
                return Unbox(reader);
            }
            catch (MemoryInaccessibleException)
            {
                return null;
            }
        }

        public bool IsNull
        {
            get { return Address == 0; }
        }

        public Pointer<T> Read(IReader reader, int address, bool relative = false)
        {
            Address = reader.ReadInt32(address, relative);
            Relative = false;
            return this;
        }

        public static Pointer<T> Create()
        {
            return new Pointer<T>();
        }

        public static Pointer<T> Create(int address)
        {
            return new Pointer<T>(address);
        }

        public static Pointer<T> Create(int address, bool relative)
        {
            return new Pointer<T>(address, relative);
        }

        public static Pointer<T> Create(IReader reader, int address, bool relative = false)
        {
            return new Pointer<T>(address).Read(reader, address, relative);
        }

        public static T CreateAndUnbox(IReader reader, int address, bool relative = false)
        {
            Pointer<T> pointer = Create();
            pointer.Read(reader, address, relative);
            return pointer.Unbox(reader);
        }
        public static T CreateAndTryUnbox(IReader reader, int address, bool relative = false)
        {
            Pointer<T> pointer = Create();
            pointer.Read(reader, address, relative);
            return pointer.TryUnbox(reader);
        }

        public static T CreateAndUnbox(IReader reader, int address, bool relative,
            Action<T, IReader, int, bool> readAction)
        {
            if (readAction == null) throw new ArgumentNullException("readAction");
            Pointer<T> pointer = Create();
            pointer.Read(reader, address, relative);
            return pointer.Unbox(reader, readAction);
        }

        public T Unbox(IReader reader, Action<T, IReader, int, bool> readAction)
        {
            if (Address == 0)
                return null;
            T obj = new T().Read(reader, Address);
            readAction(obj, reader, Address, Relative);
            return obj;
        }

        protected bool Equals(Pointer<T> other)
        {
            return Address == other.Address;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Pointer<T>) obj);
        }

        public override int GetHashCode()
        {
            return Address;
        }
    }
}
