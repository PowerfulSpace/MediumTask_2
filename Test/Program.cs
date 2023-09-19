
Type myType = typeof(Person);

Console.WriteLine("Реализованные интерфейсы:");
foreach (Type i in myType.GetInterfaces())
{
    Console.WriteLine(i.Name);
}

Console.ReadLine();

public class Person : IEater, IMovable
{
    public string Name { get; }
    public Person(string name) => Name = name;
    public void Eat() => Console.WriteLine($"{Name} eats");

    public void Move() => Console.WriteLine($"{Name} moves");
}
interface IEater
{
    void Eat();
}
interface IMovable
{
    void Move();
}