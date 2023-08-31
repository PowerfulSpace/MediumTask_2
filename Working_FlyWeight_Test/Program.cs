


string[] array = new string[1024];

for (int i = 0; i < array.Length; i++)
{
    //array[i] = new string('-', (int)Math.Pow(1024, 2));
    //array[i] = string.Intern(new string('-', (int)Math.Pow(1024, 2)));
    array[i] = string.Intern(new string('-', (int)Math.Pow(1024, 2)).ToString());



    Console.WriteLine(GC.GetTotalMemory(false) / (int)Math.Pow(1024, 2) + "MB");
}


Console.ReadLine();

