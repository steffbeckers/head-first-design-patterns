﻿using HFDP.Observer.Observers;

namespace HFDP.Observer.Subjects
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void NotifyObservers();
    }
}
