using System;
using observer.weather.interfaces;

namespace observer.weather.displays
{
    public class CurrentConditionsDisplay: IWeatherObserver, IDisplayable
    {
        private readonly IWeatherSubject _weatherData;
        private float _temperature;
        private float _humidity;
        
        public CurrentConditionsDisplay(IWeatherSubject ws)
        {
            this._weatherData = ws;
            this._weatherData.Register(this);
        }
        
        public void Display()
        {
            Console.WriteLine($"Current conditions: {this._temperature} C degrees, {this._humidity} % humidity");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this.Display();
        }
    }
}