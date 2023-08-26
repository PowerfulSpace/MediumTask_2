

Console.WriteLine("Основной поток запущен.");

var cancelTokSrc = new CancellationTokenSource();

Task task = Task.Factory.StartNew(MyTask, cancelTokSrc.Token, cancelTokSrc.Token);

Thread.Sleep(2000);

try
{
    cancelTokSrc.Cancel();

    task.Wait();
}
catch (Exception e)
{
    if (task.IsCanceled)
        Console.WriteLine("\nЗадача task отменена.\n");

    Console.WriteLine("- " + e.InnerException.Message);
}

Console.WriteLine("Основной поток завершен.");

Console.ReadKey();



static void MyTask(object ct)
{
    var cancelTok = (CancellationToken)ct;

    Console.WriteLine("MyTask() запущен.");

    for (int count = 0; count < 10; count++)
    {
        if (cancelTok.IsCancellationRequested)
        {
            Console.WriteLine("Получен запрос на отмену задачи.");
            cancelTok.ThrowIfCancellationRequested();
        }

        Thread.Sleep(500);
        Console.WriteLine("В методе MyTask(), счетчик равен: " + count);
    }

    Console.WriteLine("MyTask() завершен.");
}
