class Program
{
    static EventWaitHandle manual = null; // базовый сигнал для сигнальщика

    static void Main()
    {

        manual = new EventWaitHandle(false, EventResetMode.ManualReset, "GlobalEvent::GUID");// до первой строчки не знаем какой будет сигнальщик. Номер уникальный,какой сигнальщик создавать

        Thread thread = new Thread(Function);
        thread.IsBackground = true;
        thread.Start();

        Console.WriteLine("Нажмите любую клавишу для начала работы потока.");
        Console.ReadKey();


        manual.Set();

        Console.ReadKey();
    }

    static void Function()
    {
        manual.WaitOne(); // будет ожидать сигнала

        while (true)
        {
            Console.WriteLine("Hello world!");
            Thread.Sleep(300);
        }
    }
}
