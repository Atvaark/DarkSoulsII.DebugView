using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class CustomAttrSpecParam : IReadable<CustomAttrSpecParam>
    {
        public CustomAttrSpecParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
