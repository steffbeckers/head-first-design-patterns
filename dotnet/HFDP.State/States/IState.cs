namespace HFDP.State.States
{
    public interface IState
    {
        public void InsertQuarter();
        public void EjectQuarter();
        public void TurnCrank();
        public void Dispense();
        public void Refill();
    }
}
