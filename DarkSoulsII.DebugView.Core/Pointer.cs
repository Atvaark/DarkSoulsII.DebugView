using DarkSoulsII.DebugView.Core.Exceptions;

namespace DarkSoulsII.DebugView.Core
{
    public class Pointer<T> : IReadable<Pointer<T>>, IPointer<T> where T : class, IReadable<T>, new()
    {
        public Pointer()
        {
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
            if (IsNull)
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

        public static Pointer<T> Create(int address, bool relative = false)
        {
            return new Pointer<T>(address, relative);
        }

        public static T CreateAndUnbox(IReader reader, int address, bool relative = false)
        {
            Pointer<T> pointer = new Pointer<T>();
            pointer.Read(reader, address, relative);
            return pointer.Unbox(reader);
        }

        public static T CreateAndTryUnbox(IReader reader, int address, bool relative = false)
        {
            Pointer<T> pointer = new Pointer<T>();
            pointer.Read(reader, address, relative);
            return pointer.TryUnbox(reader);
        }

        private bool Equals(Pointer<T> other)
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
