namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Model
{
    public class FlverModelDataAdapter : IReadable<FlverModelDataAdapter>
    {
        public FlverModelData ModelData { get; set; }

        public FlverModelDataAdapter Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            ModelData = pointerFactory.Create<FlverModelData>(address + 0x0008, relative).Unbox(pointerFactory, reader);
            // 0008 MdlMirroredSkeleton
            return this;
        }

    }
}