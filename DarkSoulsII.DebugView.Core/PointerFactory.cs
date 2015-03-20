using System.Runtime.Caching;

namespace DarkSoulsII.DebugView.Core
{
    public class PointerFactory : IPointerFactory
    {
        private readonly IReader _reader;
        private readonly MemoryCache _cache;
        private readonly CacheItemPolicy _cachePolicy;

        public PointerFactory(IReader reader)
        {
            _reader = reader;
            _cache = new MemoryCache("PointerCache");
            _cachePolicy = new CacheItemPolicy();
        }

        public IPointer<T> Create<T>(int address, bool relative = false, bool dereferenced = false, bool searchCache = false) where T : class, IReadable<T>, new()
        {
            IPointerProxy<T> pointer;
            if (searchCache && TryGetFromCache(address, relative, dereferenced, out pointer))
                return pointer;
            return new Pointer<T>(address, relative, dereferenced);
        }

        public IPointerProxy<T> CreateProxy<T>(int address, bool relative = false, bool dereferenced = false, bool searchCache = false) where T : class, IReadable<T>, new()
        {
            IPointerProxy<T> pointer;
            if (searchCache && TryGetFromCache(address, relative, dereferenced, out pointer))
                return pointer;
            pointer = new PointerProxy<T>(Create<T>(address, relative, dereferenced));
            CacheProxy(pointer, address, relative, dereferenced);
            return pointer;
        }

        private bool TryGetFromCache<T>(int address, bool relative, bool dereferenced, out IPointerProxy<T> pointer) where T : class, IReadable<T>, new()
        {
            pointer = null;
            var key = GetKey<T>(address, relative, dereferenced);
            var cacheItem = _cache.GetCacheItem(key);
            if (cacheItem == null) return false;
            pointer = cacheItem.Value as IPointerProxy<T>;
            return pointer != null;
        }

        private void CacheProxy<T>(IPointer<T> pointer, int address, bool relative, bool dereferenced) where T : class, IReadable<T>, new()
        {
            var key = GetKey<T>(address, relative, dereferenced);
            _cache.Add(key, pointer, _cachePolicy);
        }
        
        public IPointer<T>[] CreateArray<T>(int address, bool relative = false, int count = 1) where T : class, IReadable<T>, new()
        {
            IPointer<T>[] result = new IPointer<T>[count];
            int offset = 0;
            for (int i = 0; i < count; i++)
            {
                var pointer = Create<T>(address + offset, relative);
                result[i] = pointer;
                offset += pointer.Size;
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

        public void RemoveProxy<T>(int address, bool relative = false, bool dereferenced = false) where T : class, IReadable<T>, new()
        {
            _cache.Remove(GetKey<T>(address, relative, dereferenced));
        }

        private static string GetKey<T>(int address, bool relative, bool dereferenced) where T : class, IReadable<T>, new()
        {
            return typeof(T).Name + address + relative + dereferenced;
        }

    }
}