using System.Diagnostics;

class Program
{
    static int[] data;

    static void MyTransform(int i)
    {
        data[i] = data[i] / 10;
        if (data[i] < 10000) data[i] = 0;
        if (data[i] > 10000 && data[i] < 20000) data[i] = 100;
        if (data[i] > 20000 && data[i] < 30000) data[i] = 200;
        if (data[i] > 30000) data[i] = 300;
    }

    static void Main()
    {
        var rand = new Random();
        var sw = new Stopwatch();
        data = new int[300000000];

        Console.WriteLine("У Вашего процессора {0} ядер.", Environment.ProcessorCount);
        Console.WriteLine(new string('-', 20));

        Console.WriteLine("Нажмите любую клавишу для начала");
        Console.ReadKey();

        sw.Start();

        Parallel.For(0, data.Length, i => data[i] = rand.Next(10));
        sw.Stop();
        Console.WriteLine("Параллельно выполняемый цикл инициализации: {0} секунд.", sw.Elapsed.TotalSeconds);
        sw.Reset();

        sw.Start();

        for (int i = 0; i < data.Length; i++) data[i] = rand.Next(10);
        sw.Stop();
        Console.WriteLine("Последовательно выполняемый цикл инициализации: {0} секунд.", sw.Elapsed.TotalSeconds);
        sw.Reset();

        Console.WriteLine();

        sw.Start();

        Parallel.For(0, data.Length, MyTransform);
        sw.Stop();
        Console.WriteLine("Параллельно выполняемый цикл преобразования: {0} секунд.", sw.Elapsed.TotalSeconds);

        sw.Reset();
        for (int i = 0; i < data.Length; i++) data[i] = rand.Next(10);

        sw.Start();

        for (int i = 0; i < data.Length; i++) MyTransform(i);
        sw.Stop();

        Console.WriteLine("Последовательно выполняемый цикл преобразования: {0} секунд.", sw.Elapsed.TotalSeconds);
        sw.Reset();

        Console.WriteLine("Основной поток завершен.");

        Console.ReadKey();
    }
}
