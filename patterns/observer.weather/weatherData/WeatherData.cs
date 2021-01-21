using System;
using System.Collections.Generic;
using System.Linq;
using observer.weather.interfaces;

namespace observer.weather.weatherData
{
    public class WeatherData: IWeatherSubject
    {
        private IList<IWeatherObserver> _observers;

        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            this._observers = new List<IWeatherObserver>();
        }
        
        public void Register(IWeatherObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Remove(IWeatherObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            for (var i = 0; i < this._observers.Count(); i++)
            {
                var observer = this._observers[i];
                observer.Update(this._temperature, this._humidity, this._pressure);
            }
        }

        public void SetMeasurments(float temp, float hum, float pres)
        {
            this._temperature = temp;
            this._humidity = hum;
            this._pressure = pres;
            this.MeasurmentsChanged();
        }

        private void MeasurmentsChanged()
        {
            this.Notify();
        }
    }
}