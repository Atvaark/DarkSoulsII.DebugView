using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Resources.Param.Character
{
    public class EquipmentCullingTargetParam : IReadable<EquipmentCullingTargetParam>
    {
        public EquipmentCullingTargetParam Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            return this;
        }
    }
}
