namespace DarkSoulsII.DebugView.Core
{
    public class CachingPointerProxy<T> : IPointer<T> where T : class, IReadable<T>, new()
    {
        private readonly IPointer<T> _pointer;
        private T _value;
        private bool _valueInitialized;

        public CachingPointerProxy(IPointer<T> pointer)
        {
            _pointer = pointer;
        }

        public bool IsNull
        {
            get
            {
                return _pointer.IsNull;
            }
        }

        public bool Dereferenced
        {
            get { return _pointer.Dereferenced; }
        }

        public T Unbox(IPointerFactory pointerFactory, IReader reader)
        {
            if (_valueInitialized)
                return _value;
            _value = _pointer.Unbox(pointerFactory, reader);
            _valueInitialized = true;
            return _value;
        }

        public T TryUnbox(IPointerFactory pointerFactory, IReader reader)
        {
            if (_valueInitialized)
                return _value;
            _value = _pointer.TryUnbox(pointerFactory, reader);
            _valueInitialized = true;
            return _value;
        }

        public void Dereference(IReader reader)
        {
            _pointer.Dereference(reader);
        }
    }
}