
Console.WriteLine("Первичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

var myDelegate = new Action(Method);

myDelegate.BeginInvoke(null, null);
Console.WriteLine("Main");

for (int i = 0; i < 80; i++)
{
    Thread.Sleep(50);
    Console.Write(".");
}
Console.ReadKey();



static void Method()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nАсинхронный метод запущен.");
    Console.WriteLine("\nВторичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

    for (int i = 0; i < 80; i++)
    {
        Thread.Sleep(60);
        Console.Write("A");
    }

    Console.WriteLine("Асинхронная операция завершена.\n");
    Console.ForegroundColor = ConsoleColor.Gray;
}

