using System.Runtime.Caching;

namespace DarkSoulsII.DebugView.Core
{
    public class CachingPointerProxyFactory : PointerFactory, ICachingPointerFactory
    {
        private readonly MemoryCache _cache;
        private readonly CacheItemPolicy _cachePolicy;

        public CachingPointerProxyFactory(IReader reader)
            : base(reader)
        {
            _cache = new MemoryCache("CachingPointerProxyCache");
            _cachePolicy = new CacheItemPolicy();
        }

        public new IPointer<T> Create<T>(int address, bool relative = false, bool dereferenced = false) where T : class, IReadable<T>, new()
        {
            IPointer<T> pointer;
            if (TryGetFromCache(address, relative, dereferenced, out pointer))
                return pointer;
            return new Pointer<T>(address, relative, dereferenced);
        }

        public IPointer<T> CreateProxy<T>(int address, bool relative = false, bool dereferenced = false) where T : class, IReadable<T>, new()
        {
            IPointer<T> pointer;
            if (TryGetFromCache(address, relative, dereferenced, out pointer))
                return pointer;
            pointer = new CachingPointerProxy<T>(base.Create<T>(address, relative, dereferenced));
            CacheProxy(pointer, address, relative, dereferenced);
            return pointer;
        }
        private bool TryGetFromCache<T>(int address, bool relative, bool dereferenced, out IPointer<T> pointer) where T : class, IReadable<T>, new()
        {
            pointer = null;
            var key = GetKey<T>(address, relative, dereferenced);
            var cacheItem = _cache.GetCacheItem(key);
            if (cacheItem == null) return false;
            pointer = cacheItem.Value as IPointer<T>;
            return pointer != null;
        }

        private void CacheProxy<T>(IPointer<T> pointer, int address, bool relative, bool dereferenced) where T : class, IReadable<T>, new()
        {
            var key = GetKey<T>(address, relative, dereferenced);
            _cache.Add(key, pointer, _cachePolicy);
        }

        public void RemoveProxy<T>(int address, bool relative = false, bool dereferenced = false) where T : class, IReadable<T>, new()
        {
            _cache.Remove(GetKey<T>(address, relative, dereferenced));
        }

        private static string GetKey<T>(int address, bool relative, bool dereferenced) where T : class, IReadable<T>, new()
        {
            string key = typeof(T).Name + address + relative + dereferenced;
            return key;
        }

    }
}