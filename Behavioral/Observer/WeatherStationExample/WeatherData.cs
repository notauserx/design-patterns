namespace Behavioral.Observer.WeatherStationExample;

public class WeatherData : IWeatherSubject
{
    private readonly IList<IWeatherObserver> _observers;

    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData()
    {
        _observers = new List<IWeatherObserver>();
    }

    public void measurementsChanged()
    {
        NotifyObservers();
    }

    public void setMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        measurementsChanged();
    }

    public void NotifyObservers()
    {
        foreach(var observer in _observers)
        {
            observer.Update(temperature, humidity, pressure);
        }
    }

    public void RegisterObserver(IWeatherObserver o)
    {
        _observers.Add(o);
    }

    public void RemoveObserver(IWeatherObserver o)
    {
        _observers.Remove(o);
    }
}