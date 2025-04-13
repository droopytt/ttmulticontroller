using System;

namespace TTMulti
{
    internal class ModeChangeRequest
    {
        public Multicontroller.ControllerMode Mode { get; }
        public string Substate { get; }
        public ModeChangeRequest(Multicontroller.ControllerMode mode, String substate)
        {
            Mode = mode;
            Substate = substate;
        }
    }
}
