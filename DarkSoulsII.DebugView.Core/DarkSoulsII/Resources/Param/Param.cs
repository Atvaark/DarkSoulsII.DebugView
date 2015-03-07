namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Param
{
    public class Param : IReadable<Param>
    {
        public string Name { get; set; }

        public Param Read(IReader reader, int address, bool relative = false)
        {
            // TODO: Implement generic param structure reading
            return this;
        }
    }
}