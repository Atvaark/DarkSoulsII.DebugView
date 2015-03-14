namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources
{
    public class ResourceObject : IReadable<ResourceObject>
    {
        public ResourceObject Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
