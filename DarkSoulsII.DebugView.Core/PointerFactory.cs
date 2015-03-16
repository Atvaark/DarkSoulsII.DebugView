namespace DarkSoulsII.DebugView.Core
{
    public class PointerFactory : IPointerFactory
    {
        protected readonly IReader Reader;

        public PointerFactory(IReader reader)
        {
            Reader = reader;
        }
        
        public IPointer<T> Create<T>(int address, bool relative = false, bool dereferenced = false) where T : class, IReadable<T>, new()
        {
            return new Pointer<T>(address, relative, dereferenced);
        }
        
        public IPointer<T>[] CreateArray<T>(int address, bool relative = false, int count = 1) where T : class, IReadable<T>, new()
        {
            IPointer<T>[] result = new IPointer<T>[count];
            int offset = 0;
            const int pointerSize = sizeof(int);
            for (int i = 0; i < count; i++)
            {
                var pointer = Create<T>(address + offset, relative);
                result[i] = pointer;
                // TODO: Let IPointer<T> inherit from IFixedSize to be able to access pointer.Size here;
                offset += pointerSize; 
            }
            return result;
        }

        public IPointer<T>[] CreateArrayDereferenced<T>(int address, bool relative = false, int count = 1) where T : class, IFixedSize, IReadable<T>, new()
        {
            IPointer<T>[] result = new IPointer<T>[count];
            int offset = 0;
            int valueSize = new T().Size;
            for (int i = 0; i < count; i++)
            {
                var pointer = Create<T>(address + offset, relative, true);
                result[i] = pointer;
                offset += valueSize;
            }
            return result;
        }
    }
}
