﻿

using System.Text.Json;

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


Console.ReadLine();


public class WeatherForecast
{
    public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string? Summary { get; set; }
}