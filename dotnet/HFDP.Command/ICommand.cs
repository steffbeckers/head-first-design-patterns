﻿namespace HFDP.Command
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
