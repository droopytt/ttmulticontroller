using System;

namespace TTMulti
{
    internal class ModeChangeRequest
    {
        public Multicontroller.ControllerMode Mode { get; }
        public string Substate { get; }
        public ModeChangeRequest(Multicontroller.ControllerMode mode, string substate)
        {
            Mode = mode;
            Substate = substate;
        }
    }
}
