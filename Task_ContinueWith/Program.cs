

Console.WriteLine("Основной поток запущен.");

var action = new Action(MyTask);
var task = new Task(action);

var continuationAction = new Action<Task>(ContinuationTask);
Task taskContinuation = task.ContinueWith(continuationAction);

task.Start();

taskContinuation.Wait();

Console.WriteLine("Основной поток завершен.");

Console.ReadKey();



static void MyTask()
{
    Console.WriteLine("MyTask() запущен.");

    for (int count = 0; count < 5; count++)
    {
        Thread.Sleep(500);
        Console.WriteLine("В методе MyTask(), счетчик равен: " + count);
    }

    Console.WriteLine("MyTask() завершен.");
}

static void ContinuationTask(Task task)
{
    Console.WriteLine("Продолжение запущено.");

    for (int count = 0; count < 5; count++)
    {
        Thread.Sleep(500);
        Console.WriteLine("В продолжении, счетчик равен: " + count);
    }

    Console.WriteLine("Продолжение завершено.");
}

