﻿using System;

namespace HFDP.State.States
{
    public class SoldState : IState
    {
        private GumballMachine _gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public void Dispense()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.State = _gumballMachine.NoQuarterState;
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                _gumballMachine.State = _gumballMachine.SoldOutState;
            }
        }

        public void Refill()
        {
        }

        public override string ToString()
        {
            return "sold";
        }
    }
}
