

using System.Text.Json;

var weatherForecast = new WeatherForecast
{
    Date = DateTime.Parse("2019-08-01"),
    TemperatureCelsius = 25,
    Summary = "Hot",
    SummaryField = "Hot",
    DatesAvailable = new List<DateTimeOffset>()
                    { DateTime.Parse("2019-08-01"), DateTime.Parse("2019-08-02") },
    TemperatureRanges = new Dictionary<string, HighLowTemps>
    {
        ["Cold"] = new HighLowTemps { High = 20, Low = -10 },
        ["Hot"] = new HighLowTemps { High = 60, Low = 20 }
    },
    SummaryWords = new[] { "Cool", "Windy", "Humid" }
};

byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(weatherForecast);
foreach (var item in jsonUtf8Bytes)
    Console.Write(item + " ");


Console.ReadLine();


public class WeatherForecast
{
    public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string? Summary { get; set; }
    public string? SummaryField;
    public IList<DateTimeOffset>? DatesAvailable { get; set; }
    public Dictionary<string, HighLowTemps>? TemperatureRanges { get; set; }
    public string[]? SummaryWords { get; set; }
}

public class HighLowTemps
{
    public int High { get; set; }
    public int Low { get; set; }
}