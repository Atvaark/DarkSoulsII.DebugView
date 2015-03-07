namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources
{
    public class ResourceObject : IReadable<ResourceObject>
    {
        public ResourceObject Read(IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
