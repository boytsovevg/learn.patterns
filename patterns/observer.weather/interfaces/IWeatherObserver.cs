namespace observer.weather.interfaces
{
    public interface IWeatherObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}