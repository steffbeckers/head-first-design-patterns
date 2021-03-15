using HFDP.Observer.Observers;
using System.Collections.Generic;

namespace HFDP.Observer.Subjects
{
    public class WeatherData : ISubject
    {
        private List<IObserver> Observers { get; set; }
        private float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public WeatherData()
        {
            this.Observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (Observers.Contains(observer))
            {
                Observers.Remove(observer);
            };
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}
