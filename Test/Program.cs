

double x1, dx, x2, x, y;
//Хитрый ввод
Console.Clear();
while (true)
{
    Console.Write("Хотите ввести данные (y/n)? ");
    ConsoleKeyInfo key = Console.ReadKey();
    if (key.Key == ConsoleKey.N)
    {
        x1 = -5.0; dx = 0.05; x2 = 5.0; //поставить значения по умолчанию
        break;
    }
    else if (key.Key == ConsoleKey.Y)
    {
        try
        {
            Console.WriteLine();
            Console.Write("X1=");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("dX=");
            dx = Convert.ToDouble(Console.ReadLine());
            Console.Write("X2=");
            x2 = Convert.ToDouble(Console.ReadLine());
        }
        catch (System.FormatException ex)
        {
            Console.WriteLine(ex.Message);
            continue;
        }
        if (!(Math.Abs(dx) > 1e-4 &
           (dx > 0 & x1 + dx <= x2 || dx < 0 & x1 + dx >= x2)))
        {
            //Дополнительные проверки корректности данных -
            //шаг не слишком мал и есть хотя бы 2 строки таблицы.
            //Сверху количество шагов не ограничиваем
            Console.WriteLine
             ("Введите допустимые начальное значение, шаг, конечное значение");
            continue;
        }
        break;
    }
}
//Обработка и форматный вывод
string OutputFormat = "{0,10:F4}\t{1,10:F4}";
Console.Clear();
Console.WriteLine(OutputFormat, "x", "y");
if (x1 > x2)
{
    double t = x1; x1 = x2; x2 = t; dx = -dx;
}
for (x = x1; x <= x2; x += dx)
{
    if (Math.Abs(x) < 1.0E-12) y = Double.NaN;
    //учёл разрыв - на самом деле, формально его в моём варианте нет
    else if (x < 0) y = Math.Log(Math.Abs(x));
    else y = Math.Sqrt(x);
    Console.WriteLine(OutputFormat, x, y);
}
Console.ReadKey();