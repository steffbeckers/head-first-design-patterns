using System;

namespace HFDP.State.States
{
    public class HasQuarterState : IState
    {
        private GumballMachine _gumballMachine;
        private Random _random = new Random(DateTime.Now.Millisecond);

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.State = _gumballMachine.NoQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = _random.Next(10);
            if ((winner == 0) && (_gumballMachine.Count > 1))
            {
                _gumballMachine.State = _gumballMachine.WinnerState;
            }
            else
            {
                _gumballMachine.State = _gumballMachine.SoldState;
            }
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void Refill()
        {
        }

        public override string ToString()
        {
            return "has quarter";
        }
    }
}
