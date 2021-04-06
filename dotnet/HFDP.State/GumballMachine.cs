using HFDP.State.States;
using System;

namespace HFDP.State
{
    public class GumballMachine
    {
        public IState SoldOutState { get; }
        public IState NoQuarterState { get; }
        public IState HasQuarterState { get; }
        public IState SoldState { get; }
        public IState WinnerState { get; }

        public IState State { get; set; }
        public int Count;

        public GumballMachine(int numberOfGumballs)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);

            Count = numberOfGumballs;
            if (numberOfGumballs > 0)
            {
                State = NoQuarterState;
            }
            else
            {
                State = SoldOutState;
            }
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
            {
                Count--;
            }
        }

        public void Refill(int numberOfGumballs)
        {
            Count += numberOfGumballs;
            Console.WriteLine($"The gumball machine was just refilled; it's new count is: {Count}");
            State.Refill();
        }

        public override string ToString()
        {
            return "Mighty Gumball, Inc.\n" +
                   ".NET-enabled Standing Gumball Model #2021\n" +
                   $"Inventory: {Count} gumballs\n" +
                   $"Machine state: {State}";
        }
    }
}
