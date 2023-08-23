
class Program
{
    static readonly AutoResetEvent auto = new AutoResetEvent(false);
    static void Main()
    {
        Console.WriteLine("Нажмите на любую клавишу для перевода AutoResetEvent в сигнальное состояние.\n");

        var thread = new Thread(Function1);
        thread.Start();

        Console.ReadKey();
        auto.Set();

        Console.ReadKey();
        auto.Set();

        Console.ReadKey();
    }

    static void Function1()
    {
        Console.WriteLine("Красный свет");
        auto.WaitOne();
        Console.WriteLine("Желтый");
        auto.WaitOne();
        Console.WriteLine("Зеленый");
    }
}
