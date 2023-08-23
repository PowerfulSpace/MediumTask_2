class Program
{
    //Если не задать имея для Mutex, тогда каждый запускаемая программа будет создовать свой собственный Mutex
    //в нашем случае с имеющимся именем у mutex. Будет работать 1 для всех
    private static readonly Mutex Mutex1 = new Mutex(false, "MutexSample:AAED7056-380D-412E-9608-763495211EA8");

    static void Main()
    {
        var threads = new Thread[5];

        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(Function)
            {
                Name = i.ToString()
            };
            threads[i].Start();
        }

        Console.ReadKey();
    }

    static void Function()
    {
        bool myMutex = Mutex1.WaitOne();

        Console.WriteLine("Поток {0} зашел в защищенную область.", Thread.CurrentThread.Name);
        Thread.Sleep(2000);
        Console.WriteLine("Поток {0}  покинул защищенную область.\n", Thread.CurrentThread.Name);
        Mutex1.ReleaseMutex();
    }
}
