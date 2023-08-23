class Program
{
    static readonly AutoResetEvent auto = new AutoResetEvent(false);
    static void Main()
    {
        var thread = new Thread(Function1);
        thread.Start();

        var thread2 = new Thread(TrafficLight);
        thread2.Start();


        Console.ReadKey();
    }

    static void Function1()
    {
        while (true)
        {
            ShowColor("Красный свет", ConsoleColor.Red);
            auto.WaitOne();
            ShowColor("Желтый", ConsoleColor.Yellow);
            auto.WaitOne();
            ShowColor("Зеленый", ConsoleColor.Green);
            auto.WaitOne();
        }
    }

    static void ShowColor(string colorString, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(colorString);
        Console.ForegroundColor = ConsoleColor.White;
    }
    static void TrafficLight()
    {
        while (true)
        {
            Thread.Sleep(1000);
            auto.Set();
        }
    }
}
