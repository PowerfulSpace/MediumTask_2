

using System.Text.Json;


var weatherForecast = new WeatherForecast
{
    Date = DateTime.Parse("2019-08-01"),
    TemperatureCelsius = 25,
    Summary = "Hot"
};

//Обычная сериализация в переменную стринг
string jsonString = JsonSerializer.Serialize(weatherForecast);
Console.WriteLine(jsonString);

//Сериализация в файл, после чтение файла
string fileName2 = "WeatherForecast.json";
string jsonString2 = JsonSerializer.Serialize(weatherForecast);
File.WriteAllText(fileName2, jsonString2);
Console.WriteLine(File.ReadAllText(fileName2));

//Асинхронная сериализация. С последующим закрытием неупровляймого обьекта с помощи DisposeAsync
string fileName3 = "WeatherForecast.json";
using FileStream createStream3 = File.Create(fileName3);
await JsonSerializer.SerializeAsync(createStream3, weatherForecast);
await createStream3.DisposeAsync();
Console.WriteLine(File.ReadAllText(fileName3));

Console.ReadLine();


public class WeatherForecast
{
    public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string? Summary { get; set; }
}