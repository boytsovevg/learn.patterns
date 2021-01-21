namespace observer.weather.interfaces
{
    public interface IWeatherSubject
    {
        void Register(IWeatherObserver observer);

        void Remove(IWeatherObserver observer);

        void Notify();
    }
}