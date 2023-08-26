


Console.WriteLine("Основной поток запущен.");

var action = new Action(MyTask);

var task = new Task(action);

task.Start();    //- выполнение задачи асинхронно
//task.Wait();   //- ожидать завершение асинхронно вызванной задачи

//task.RunSynchronously(); - выполнение задачи синхронно
for (int i = 0; i < 60; i++)
{
    Console.Write(".");
    Thread.Sleep(100);
}

Console.WriteLine("Основной поток завершен.");

Console.ReadKey();



static void MyTask()
{
    Console.WriteLine("MyTask() запущен.");

    for (int count = 0; count < 20; count++)
    {
        Thread.Sleep(500);
        Console.WriteLine("В методе MyTask(), счетчик равен: " + count);
    }

    Console.WriteLine("MyTask() завершен.");
}
