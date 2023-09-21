using Microsoft.Extensions.DependencyInjection;
using System;

IServiceCollection services = new ServiceCollection()
    .AddScoped<ICounter, RandomCounter>();

using ServiceProvider serviceProvider = services.BuildServiceProvider();

PrintCounters();
PrintCounters();
void PrintCounters()
{
    using IServiceScope scope = serviceProvider.CreateScope(); // контекст scope
    var counter1 = scope.ServiceProvider.GetService<ICounter>();
    var counter2 = scope.ServiceProvider.GetService<ICounter>();
    Console.WriteLine($"Counter1: {counter1?.Value}; Counter2: {counter2?.Value}");
}


void PrintCounters()
{
    var counter1 = serviceProvider.GetService<ICounter>();
    var counter2 = serviceProvider.GetService<ICounter>();
    Console.WriteLine($"Counter1: {counter1?.Value}; Counter2: {counter2?.Value}");
}

static interface ICounter
{
    int Value { get; }
}
static class RandomCounter : ICounter
{
    static Random rnd = new Random();
    private int _value;
    public RandomCounter() => _value = rnd.Next(0, 1000000);
    public int Value => _value;
}


