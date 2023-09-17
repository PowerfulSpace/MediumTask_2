using System.Net.Http.Json;

HttpClient httpClient = new HttpClient();


// отправляемый объект 
Person tom = new Person { Name = "Tom", Age = 38 };
// создаем JsonContent
JsonContent content = JsonContent.Create(tom);
// отправляем запрос
using var response = await httpClient.PostAsync("https://localhost:7094/create", content);
Person? person = await response.Content.ReadFromJsonAsync<Person>();
Console.WriteLine($"{person?.Id} - {person?.Name}");

Console.ReadLine();


class Person
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public int Age { get; set; }
}