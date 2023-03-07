using Behavioral.Observer.WeatherStationExample;

namespace Behavioral.Tests.Observer;

public class WeatherStationExampleTests
{
    [Fact]
    public void set_measuremets_updates_current_conditions_data_when_subscribed()
    {
        var weatherData = new WeatherData();

        var currentConditionsData = new CurrentWeatherConditionsData();

        weatherData.RegisterObserver(currentConditionsData);

        weatherData.setMeasurements(80, 65, 30.4f);

        Assert.Equal(80, currentConditionsData.Temp);
        Assert.Equal(65, currentConditionsData.Humidity);
        Assert.Equal(30.4f, currentConditionsData.Pressure);

        weatherData.setMeasurements(81, 64, 30.2f);

        Assert.Equal(81, currentConditionsData.Temp);
        Assert.Equal(64, currentConditionsData.Humidity);
        Assert.Equal(30.2f, currentConditionsData.Pressure);

    }

    [Fact]
    public void set_measuremets_updates_current_conditions_data_and_stat_data_when_subscribed()
    {
        var weatherData = new WeatherData();

        var currentConditionsData = new CurrentWeatherConditionsData();
        var tempStatData = new WeatherTemparatureStatisticsData();

        weatherData.RegisterObserver(currentConditionsData);
        weatherData.RegisterObserver(tempStatData);

        weatherData.setMeasurements(80, 65, 30.4f);
        weatherData.setMeasurements(81, 65, 30.4f);
        weatherData.setMeasurements(82, 70, 29.2f);

        Assert.Equal(82, currentConditionsData.Temp);
        Assert.Equal(70, currentConditionsData.Humidity);
        Assert.Equal(29.2f, currentConditionsData.Pressure);

        Assert.Equal(82, tempStatData.Max);
        Assert.Equal(80, tempStatData.Min);
        Assert.Equal(81, tempStatData.Avg);
    }
}