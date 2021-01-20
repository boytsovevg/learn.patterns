using System.Collections.Generic;
using observer.weather.interfaces;

namespace observer.weather.weatherData
{
    public class WeatherData: ISubject
    {
        private IEnumerable<IObserver> _observers;
        
        public void Register(IObserver observer)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(IObserver observer)
        {
            throw new System.NotImplementedException();
        }

        public void Notify()
        {
            throw new System.NotImplementedException();
        }
    }
}