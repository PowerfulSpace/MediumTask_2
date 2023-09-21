using Microsoft.Extensions.DependencyInjection;
using System;

var services = new ServiceCollection()
    .AddTransient<ICounter, RandomCounter>();

using ServiceProvider serviceProvider = services.BuildServiceProvider();

PrintCounters();
PrintCounters();





void PrintCounters()
{
    var counter1 = serviceProvider.GetService<ICounter>();
    var counter2 = serviceProvider.GetService<ICounter>();
    Console.WriteLine($"Counter1: {counter1?.Value}; Counter2: {counter2?.Value}");
}

public interface ICounter
{
    int Value { get; }
}
public class RandomCounter : ICounter
{
    static Random rnd = new Random();
    private int _value;
    public RandomCounter() => _value = rnd.Next(0, 1000000);
    public int Value => _value;
}