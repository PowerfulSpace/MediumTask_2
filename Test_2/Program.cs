

using System.Linq;
using System.Threading.Tasks;

List<int> _dataTask1 = new List<int> { 3, 13, 12, 157, 14, 77, 75, 13, 200, 156, 14, 21 };
List<int> _dataTask2 = new List<int> { 3, 13, -2, 12, 157, 14, -55, 77, 75, 13, -344, 200, 156, 14, 21, 9, 6, 5 };
List<string> _dataTask3 = new List<string> { "ADJSLFKHJL", "FAJL", "ADJPLFKHJL", "FATL", "FD", "FAFADFSFDAFR", "FY" };
List<string> _dataTask4 = new List<string> { "asdf", "Rew", "trafa", "nadf", "Slos", "At", "new" };
List<int> _dataTask5 = new List<int> { -12, -33, 134, 12, 1, -3, 99, 199, 5, 17, -121, 10 };
List<int> _dataTask6 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
List<int> _dataATask7 = new List<int> { 1, 4, 3, 5, 7, 2, 10, 2, 5, 7 };
List<int> _dataBTask7 = new List<int> { 1, 4, 3, 5, 7, 2, 10, 2, 5, 7 };
List<int> _dataATask8 = new List<int> { 1, 43, 275 };
List<int> _dataBTask8 = new List<int> { 1, 14, 13, 21, 5, 2, 10, 73, 555, 80 };

#region Task_1
Console.WriteLine("\nЗадача_1");
Print(Task_1(_dataTask1));
#endregion
#region Task_2
Console.WriteLine("\nЗадача_2");
Print(Task_2(_dataTask2));
#endregion
#region Task_3
Console.WriteLine("\nЗадача_3");
Print(Task_3(_dataTask3));
#endregion
#region Task_4
Console.WriteLine("\nЗадача_4");
Print(Task_4(_dataTask4));
#endregion
#region Task_5
Console.WriteLine("\nЗадача_5");
Print(Task_5(_dataTask5));
#endregion
#region Task_6
Console.WriteLine("\nЗадача_6");
Print(Task_6(_dataTask6));
#endregion
#region Task_7
Console.WriteLine("\nЗадача_7");
Print(Task_7(_dataATask7, _dataBTask7, 6, 4));
#endregion
#region Task_8
Console.WriteLine("\nЗадача_8");
Print(Task_8(_dataATask8, _dataBTask8));
#endregion

Console.ReadLine();

#region Task_1
//  1.    Дана целочисленная последовательность. Извлечь из нее все нечетные числа,
//сохранив их исходный порядок следования и удалив все вхождения повторяющихся элементов, кроме первых.

static List<int> Task_1(List<int> items) => items
    .Where(x => x % 2 != 0)
    .Distinct()
    .ToList();
#endregion
#region Task_2
//  2.  Дана целочисленная последовательность. Извлечь из нее все
//положительные двузначные числа, отсортировав их по возрастанию.

static List<int> Task_2(List<int> items) => items
        .Where(x => x > 0 && x.ToString().Length == 2)
        .OrderBy(y => y)
        .ToList();
#endregion
#region Task_3
//  3.  Дана строковая последовательность. Строки последовательности содержат только
//заглавные буквы латинского алфавита. Отсортировать последовательность
//по возрастанию длин строк, а строки одинаковой длины – по убыванию.

static List<string> Task_3(List<string> items) => items
        .OrderBy(x => x.Length)
        .ThenByDescending(x => x)
        .ToList();
#endregion
#region Task_4
//  4.  Дана последовательность непустых строк A. Получить последовательность символов,
//каждый элемент которой является начальным символом соответствующей строки из A.
//Порядок символов должен быть обратным по отношению к порядку элементов исходной последовательности.
static List<char> Task_4(List<string> items) => items
        .Select(x => x[0])
        .Reverse()
        .ToList();
#endregion
#region Task_5
//  5.  Дана целочисленная последовательность. Обрабатывая только положительные числа,
//получить последовательность их последних цифр и удалить в полученной последовательности
//все вхождения одинаковых цифр, кроме первого. Порядок полученных цифр
//должен соответствовать порядку исходных чисел.
static List<int> Task_5(List<int> items) => items
        .Where(x => x > 0)
        .Select(x => x % 10)
        .Distinct()
        .ToList();
#endregion
#region Task_6
//  6.  Дана целочисленная последовательность A. Получить новую последовательность чисел,
//элементы которой определяются по соответствующим элементам последовательности A
//следующим образом: если порядковый номер элемента A делится на 3 (3, 6, …),
//то этот элемент в новую последовательность не включается; если остаток от деления
//порядкового номера на 3 равен 1 (1, 4, …), то в новую последовательность добавляется
//удвоенное значение этого элемента; в противном случае (для элементов A с номерами 2, 5, …)
//элемент добавляется в новую последовательность без изменений.
//В полученной последовательности сохранить исходный порядок следования элементов.
static List<int> Task_6(List<int> items)
{
    return items
        .Select(x => x % 3 == 1 ? x * 2 : x)
        .Where(x => x % 3 != 0)
        .ToList();
}
#endregion
#region Task_7
//  7.  Даны целые числа K1 и K2 и целочисленные последовательности A и B. Получить последовательность,
//содержащую все числа из A, большие K1, и все числа из B, меньшие K2.
//Отсортировать полученную последовательность по возрастанию.
static List<int> Task_7(List<int> itemsA, List<int> itemsB, int k1, int k2)
{
    return itemsA        
        .Where(x => x > k1)
        .Concat(itemsB.Where(x => x < k2))
        .OrderBy(x => x)
        .ToList();
}
#endregion

#region Task_8
//  8.  Даны последовательности положительных целых чисел A и B; все числа в каждой последовательности различны.
//Найти последовательность всех пар чисел, удовлетворяющих следующим условиям:
//первый элемент пары принадлежит последовательности A, второй принадлежит B,
//и оба элемента оканчиваются одной и той же цифрой. Результирующая последовательность
//называется внутренним объединением последовательностей A и B по ключу,
//определяемому последними цифрами исходных чисел. Представить найденное
//объединение в виде последовательности строк, содержащих первый и второй элементы пары,
//разделенные дефисом, например, «49-129». Порядок следования пар должен определяться
//исходным порядком элементов последовательности A, а для равных первых элементов – порядком
//элементов последовательности B.
static List<int> Task_8(List<int> itemsA, List<int> itemsB)
{
    return itemsA;
}
#endregion



static void Print<T>(List<T> items)
{
    foreach (var item in items)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}