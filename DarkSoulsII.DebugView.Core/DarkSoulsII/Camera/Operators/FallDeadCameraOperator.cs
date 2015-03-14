﻿namespace DarkSoulsII.DebugView.Core.DarkSoulsII.Camera.Operators
{
    public class FallDeadCameraOperator : PerspectiveCameraOperator, IReadable<FallDeadCameraOperator>
    {
        public new FallDeadCameraOperator Read(IPointerFactory pointerFactory, IReader reader, int address, bool relative = false)
        {
            base.Read(pointerFactory, reader, address, relative);
            return this;
        }
    }
}
