
//работает только на старой версии
class Program
{

    static void Main()
    {
        //Console.WriteLine("Первичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

        //var myDelegate = new Func<int, int, int>(Method);

        //myDelegate.BeginInvoke(1, 2, CallBack, "a + b = {0}");

        //Console.WriteLine("Первичный поток завершил работу.");

        Console.ReadKey();
    }

    static int Method(int a, int b)
    {

        Console.WriteLine("Вторичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(3000);
        return a + b;
    }

    //static void CallBack(IAsyncResult iAsyncResult)
    //{
    //    var asyncResult = iAsyncResult as AsyncResult;
    //    var caller = (Func<int, int, int>)asyncResult.AsyncDelegate;

    //    int sum = caller.EndInvoke(iAsyncResult);

    //    string result = string.Format(iAsyncResult.AsyncState.ToString(), sum);
    //    Console.WriteLine("Результат асинхронной операции: " + result);
    //}

}
