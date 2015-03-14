namespace DarkSoulsII.DebugView.Core
{
    public class PointerFactory
    {
        private readonly IReader _reader;

        public PointerFactory(IReader reader)
        {
            _reader = reader;
        }
    }
}
