namespace Behavioral.Observer.WeatherStationExample;

public interface IWeatherObserver
{
    void Update(float temp, float humidity, float pressure);
}