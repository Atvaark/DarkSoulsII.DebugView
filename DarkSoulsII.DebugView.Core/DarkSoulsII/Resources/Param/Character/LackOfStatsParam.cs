namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Param.Character
{
    public class LackOfStatsParam : IReadable<LackOfStatsParam>
    {
        public LackOfStatsParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
