using System.Collections.Generic;
using System.Linq;
using DarkSoulsII.DebugView.Core;
using DarkSoulsII.DebugView.Model.Rtti;

namespace DarkSoulsII.DebugView.Model.Camera.Operators
{
    public class TransitionCameraOperator : PerspectiveCameraOperator, IReadable<TransitionCameraOperator>
    {
        public TransitionCameraOperator()
        {
            CameraOperators = new List<CameraOperator>();
        }

        public List<CameraOperator> CameraOperators { get; set; }
        public CameraOperator CurrentOperator { get; set; }
        public CameraOperatorType CurrentOperatorType { get; set; }

        public new TransitionCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);

            // TODO: Check if there is an initialized flag in this class
            int cameraOperatorsAddress = reader.ReadInt32(address + 0x00B4, relative);
            if (cameraOperatorsAddress == 0)
                return this;
            CameraOperators = reader.ReadInt32(10, cameraOperatorsAddress)
                .Select(a => new CameraOperatorResolver().ResolvePointer(pointerFactory, reader, a)
                .Unbox(pointerFactory, reader))
                .ToList();
            var index = reader.ReadInt32(address + 0x00C4, relative);
            CurrentOperator = CameraOperators.ElementAt(index);
            CurrentOperatorType = (CameraOperatorType)index;
            int freeze = reader.ReadInt32(address + 0x00C8, relative);
            int index2 = reader.ReadInt32(address + 0x00CC, relative);
            return this;
        }
    }
}
