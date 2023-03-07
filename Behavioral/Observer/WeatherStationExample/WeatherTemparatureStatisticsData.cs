namespace Behavioral.Observer.WeatherStationExample;

public class WeatherTemparatureStatisticsData : IWeatherObserver, IWeatherReportDisplay
{
    public float Min => _temperatureReports.Min();
    
    public float Max => _temperatureReports.Max();

    public float Avg => _temperatureReports.Sum() / _temperatureReports.Count();

    private List<float> _temperatureReports;

    public WeatherTemparatureStatisticsData()
    {
        _temperatureReports = new List<float>();
    }

    public void Update(float temp, float humidity, float pressure)
    {
        _temperatureReports.Add(temp);
    }

    public void Display()
    {
        throw new NotImplementedException();
    }
}