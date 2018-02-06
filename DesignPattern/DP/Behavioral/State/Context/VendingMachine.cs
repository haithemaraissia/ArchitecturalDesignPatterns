using System;

namespace DesignPattern.DP.Behavioral.State
{
    public class VendingMachine
    {
        private VendingState _state;

        public VendingMachine(VendingState state)
        {
            State = state;
        }

        // Gets or sets the state
        public VendingState State
        {
            get { return _state; }
            set

            {
                _state = value;
                Console.WriteLine("State: " + _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
