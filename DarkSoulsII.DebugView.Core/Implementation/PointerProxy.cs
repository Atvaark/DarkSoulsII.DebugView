using System;

namespace DarkSoulsII.DebugView.Core.Implementation
{
    public class PointerProxy<T> : IPointerProxy<T> where T : class, IReadable<T>, new()
    {
        private readonly IPointer<T> _pointer;
        private bool _valueInitialized;

        public PointerProxy(IPointer<T> pointer)
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

        public int Size
        {
            get { return IntPtr.Size; }
        }

        public T Value { get; private set; }

        public bool ValueInitialized
        {
            get { return _valueInitialized; }
        }

        public T Unbox(IPointerFactory pointerFactory, IReader reader)
        {
            if (_valueInitialized)
                return Value;
            Value = _pointer.Unbox(pointerFactory, reader);
            _valueInitialized = true;
            return Value;
        }

        public T TryUnbox(IPointerFactory pointerFactory, IReader reader)
        {
            if (_valueInitialized)
                return Value;
            Value = _pointer.TryUnbox(pointerFactory, reader);
            _valueInitialized = true;
            return Value;
        }

        public void Dereference(IReader reader)
        {
            _pointer.Dereference(reader);
        }

    }
}