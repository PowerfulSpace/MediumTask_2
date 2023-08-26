class Program
{
    static int[] data;

    static void MyTransform(int i, ParallelLoopState state)
    {
        if (data[i] < 0)
            state.Break();

        data[i] = data[i] / 10;

        if (data[i] < 10000) data[i] = 0;
        if (data[i] > 10000 && data[i] < 20000) data[i] = 100;
        if (data[i] > 20000 && data[i] < 30000) data[i] = 200;
        if (data[i] > 30000) data[i] = 300;
        Console.WriteLine(i);
    }

    static void Main()
    {
        Console.WriteLine("Основной поток запущен.");

        data = new int[100000000];

        for (int i = 0; i < data.Length; i++)
            data[i] = i;

        data[1000] = -10;

        ParallelLoopResult loopResult = Parallel.For(0, data.Length, MyTransform);

        if (!loopResult.IsCompleted)
            Console.WriteLine("\nЦикл завершился преждевременно." +
                " На шаге {0} обнаружено отрицательное значение.\n", loopResult.LowestBreakIteration);

        Console.WriteLine("Основной поток завершен.");

        Console.ReadKey();
    }
}
