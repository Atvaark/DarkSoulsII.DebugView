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
    }
}
