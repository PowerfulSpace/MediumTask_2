class Program
{

    private static ManualResetEvent manual = new ManualResetEvent(false);

    static void Main()
    {
        Console.WriteLine("Нажмите на любую клавишу для перевода ManualResetEvent в сигнальное состояние.\n");

        Thread[] threads = { new Thread(Function1), new Thread(Function2) };

        foreach (Thread thread in threads)
            thread.Start();

        Console.ReadKey();
        manual.Set();


        Console.ReadKey();
    }

    static void Function1()
    {
        Console.WriteLine("Поток 1 запущен и ожидает сигнала.");
        manual.WaitOne();
        Console.WriteLine("Поток 1 завершается.");

    }

    static void Function2()
    {
        Console.WriteLine("Поток 2 запущен и ожидает сигнала.");
        manual.WaitOne();
        Console.WriteLine("Поток 2 завершается.");
    }
}
