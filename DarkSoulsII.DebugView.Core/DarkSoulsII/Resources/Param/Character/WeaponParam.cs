namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Resources.Param.Character
{
    public class WeaponParam : IReadable<WeaponParam>
    {
        public WeaponParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
