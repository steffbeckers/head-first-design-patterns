using HFDP.Observer.Data;
using HFDP.Observer.DisplayElements;
using System;

namespace HFDP.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weather Station Simulator");
            Console.WriteLine("-------------------------");

            Console.WriteLine();

            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(14, 23, 26);
            weatherData.SetMeasurements(9, 57, 28);
            weatherData.SetMeasurements(23, 10, 35);
        }
    }
}
