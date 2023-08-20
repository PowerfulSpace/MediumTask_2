

using System.Text.Json;

//--------------------------------------------------------------Сериализуем в файл
var weatherForecast = new WeatherForecast
{
    Date = DateTime.Parse("2019-08-01"),
    TemperatureCelsius = 25,
    Summary = "Hot"
};

string fileName = "WeatherForecast.json";
string jsonString = JsonSerializer.Serialize(weatherForecast);
File.WriteAllText(fileName, jsonString);
Console.WriteLine(File.ReadAllText(fileName));
//---------------------------------------------------------------------------------

//-------------------------------------------------------------десериализуем из файла
string fileName2 = "WeatherForecast.json";
string jsonString2 = File.ReadAllText(fileName2);
WeatherForecast weatherForecast2 = JsonSerializer.Deserialize<WeatherForecast>(jsonString2)!;

Console.WriteLine($"Date: {weatherForecast2.Date}");
Console.WriteLine($"TemperatureCelsius: {weatherForecast2.TemperatureCelsius}");
Console.WriteLine($"Summary: {weatherForecast2.Summary}");
//---------------------------------------------------------------------------------
Console.ReadLine();


public class WeatherForecast
{
    public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string? Summary { get; set; }
}