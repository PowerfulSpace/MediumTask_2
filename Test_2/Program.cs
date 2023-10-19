

using System.Linq;
using System.Threading.Tasks;

//List<int> _dataTask1 = new List<int> { 3, 13, 12, 157, 14, 77, 75, 13, 200, 156, 14, 21 };
List<int> _dataTask1 = new List<int> { 3, 13, -2, 12, 157, 14, -55, 77, 75, 13, -344, 200, 156, 14, 21, 9, 6, 5 };
List<int> result;

Print(_dataTask1);

Console.WriteLine("\nЗадача_1");
result = Task_1(_dataTask1);
Print(result);

Console.WriteLine("\nЗадача_2");
result = Task_2(_dataTask1);
Print(result);


Console.ReadLine();


//  1.    Дана целочисленная последовательность. Извлечь из нее все нечетные числа,
//сохранив их исходный порядок следования и удалив все вхождения повторяющихся элементов, кроме первых.

static List<int> Task_1(List<int> items) => items
    .Where(x => x % 2 != 0)
    .Distinct()
    .ToList();



//  2.  Дана целочисленная последовательность. Извлечь из нее все
//положительные двузначные числа, отсортировав их по возрастанию.

static List<int> Task_2(List<int> items)
{
    return items
        .Where(x => x > 0 && x.ToString().Length == 2)
        .OrderBy(y => y)
        .ToList();
}

//  3.  Дана строковая последовательность. Строки последовательности содержат только
//заглавные буквы латинского алфавита. Отсортировать последовательность
//по возрастанию длин строк, а строки одинаковой длины – по убыванию.



static void Print(List<int> items)
{
    foreach (var item in items)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}