using DarkSoulsII.DebugView.Core;

namespace DarkSoulsII.DebugView.Model.Model
{
    public class ModelCtrl : IReadable<ModelCtrl>
    {
        public FlverModelDataAdapter ModelDataAdapter { get; set; }

        public ModelCtrl Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ModelDataAdapter = pointerFactory.Create<FlverModelDataAdapter>(address + 0x0060, relative).Unbox(pointerFactory, reader);
            return this;
        }

    }
}