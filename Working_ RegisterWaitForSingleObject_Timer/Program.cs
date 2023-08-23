class Program
{
    static void Main()
    {
        AutoResetEvent auto = new AutoResetEvent(false);
        WaitOrTimerCallback callback = new WaitOrTimerCallback(CallbackMethod);


        var waitHandle = ThreadPool.RegisterWaitForSingleObject(auto, callback, null, 1000, false);
        //      ThreadPool.RegisterWaitForSingleObject(auto, callback, null, Timeout.Infinite, true);

        //auto - От кого ждать сигнал
        //callback - что выполнять
        //null - 1-й аргумент Callback метода (object state)
        //1000 - интервал между вызовами Callback метода
        //false - (true - вызвать callback метод один раз. false - вызывать Callback метод с интервалом)

        Console.WriteLine("S - сигнал, Q - выход");

        while (true)
        {
            string operation = Console.ReadKey(true).KeyChar.ToString().ToUpper();

            if (operation == "S")
            {
                auto.Set();
            }
            if (operation == "Q")
            {
                waitHandle.Unregister(auto);
                break;
            }
        }
        Console.ReadKey();
    }

    static void CallbackMethod(object state, bool timedOut)
    {
        Console.WriteLine("Signal");
    }
}
