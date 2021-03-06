using System;
using observer.weather.interfaces;

namespace observer.weather.displays
{
    public class StatisticsDisplay: IWeatherObserver, IDisplayable
    {
        private readonly IWeatherSubject _weatherData;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public StatisticsDisplay(IWeatherSubject ws)
        {
            this._weatherData = ws;
            this._weatherData.Register(this);
        }
        
        public void Display()
        {
            Console.WriteLine($"Weather statistics: {this._temperature} C, {this._humidity} %, {this._pressure} Pa");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            this.Display();
        }
    }
}