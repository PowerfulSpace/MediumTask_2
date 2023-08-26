class Program
{
    static int[] data;

    static void DisplayData(int v, ParallelLoopState state)
    {
        if (v < 0)
            state.Break();

        Console.WriteLine("Значение: " + v);
    }

    static void Main()
    {
        Console.WriteLine("Основной поток запущен.");

        data = new int[100000000];

        for (int i = 0; i < data.Length; i++)
            data[i] = i;

        data[1000] = -10;

        ParallelLoopResult loopResult = Parallel.ForEach(data, DisplayData);

        if (!loopResult.IsCompleted)
            Console.WriteLine("\nЦикл завершился преждевременно." +
                " На шаге {0} обнаружено отрицательное значение.\n", loopResult.LowestBreakIteration);

        Console.WriteLine("Основной поток завершен.");

        Console.ReadKey();
    }
}
