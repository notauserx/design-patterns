namespace Behavioral.Observer.WeatherStationExample;

public class CurrentWeatherConditionsData : IWeatherObserver, IWeatherReportDisplay
{
    public float Temp { get; private set; }
    public float Humidity { get; private set; }
    public float Pressure { get; private set; }

    public void Update(float temp, float humidity, float pressure)
    {
        Temp = temp;
        Humidity = humidity;
        Pressure = pressure;
    }

    public void Display()
    {
        throw new NotImplementedException();
    }
}
