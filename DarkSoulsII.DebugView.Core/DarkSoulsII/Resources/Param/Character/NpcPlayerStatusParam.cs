namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Param.Character
{
    public class NpcPlayerStatusParam : IReadable<NpcPlayerStatusParam>
    {
        public NpcPlayerStatusParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
