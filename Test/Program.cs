
//Создайте приложение, которое может быть запущено только в одном экземпляре (используя именованный Mutex). 


public class Program
{
    public static bool flag;
  
    public static void Main()
    {
        Thread thread = new Thread(Function);
        thread.Start();
        Thread.Sleep(1000);
        flag = true;

        Console.WriteLine("-----------");
        Console.ReadKey();
    }
    
    static void Function()
    {
        while (!flag)
        {
            Console.WriteLine("Function");
        } 
    }
}