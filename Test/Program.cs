

Console.WriteLine("Начало работы программы");
ShowThreadInfo();
Console.WriteLine("Запускаем Task1 в потоке из пула потоков");
ThreadPool.QueueUserWorkItem(new WaitCallback(Task1));
ShowThreadInfo();
Console.WriteLine("Запускаем Task2 в потоке из пула потоков");
Thread.Sleep(1000);
ThreadPool.QueueUserWorkItem(Task2);
ShowThreadInfo();
Console.WriteLine("Главный поток.");

Thread.Sleep(1000);

Console.WriteLine("Главный поток завершен.\n");

Console.WriteLine("Task1 и Task2 закончили работу");
ShowThreadInfo();
Console.ReadKey();



static void Task1(Object state)
{
    Thread.CurrentThread.Name = "1";
    Console.WriteLine("Поток {0}:{1}", Thread.CurrentThread.Name, Thread.CurrentThread.ManagedThreadId);
    Console.WriteLine();
    Thread.Sleep(200);
}

static void Task2(Object state)
{
    Thread.CurrentThread.Name = "2";
    Console.WriteLine("Поток {0}:{1}", Thread.CurrentThread.Name, Thread.CurrentThread.ManagedThreadId);
    Thread.Sleep(200);
}


static void ShowThreadInfo()
{
    int availableWorkThreads, availableIOThreads, maxWorkThreads, maxIOThreads;
    ThreadPool.GetAvailableThreads(out availableWorkThreads, out availableIOThreads);
    ThreadPool.GetMaxThreads(out maxWorkThreads, out maxIOThreads);
    Console.WriteLine("-------------Доступно рабочих потоков в пуле:{0} из {1}", availableWorkThreads, maxWorkThreads);
    Console.WriteLine("-------------Доступно потоков ввода-вывода в пуле:{0} из {1}\n", availableIOThreads, maxIOThreads);
}
