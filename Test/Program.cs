//Дана целочисленная последовательность. Извлечь из нее все нечетные числа,
//сохранив их исходный порядок следования и удалив все вхождения повторяющихся элементов, кроме первых.

List<int> _dataTask1 = new List<int> { 3, 13, 12, 157, 14, 77, 75, 13, 200, 156, 14, 21 };
List<int> _dataTask2 = new List<int> { -12, -33, 134, 12, 1, -3, 99, 199, 5, 17, -121, 10 };
List<string> _dataTask3 = new List<string> { "ADJSLFKHJL", "FAJL", "ADJPLFKHJL", "FATL", "FD", "FAFADFSFDAFR", "FY" };
List<string> _dataTask4 = new List<string> { "asdf", "Rew", "trafa", "nadf", "Slos", "At", "new" };
List<int> _dataTask5 = new List<int> { -12, -33, 134, 12, 1, -3, 99, 199, 5, 17, -121, 10 };
List<int> _dataTask6 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
List<int> _dataATask7 = new List<int> { 1, 4, 3, 5, 7, 2, 10, 2, 5, 7 };
List<int> _dataBTask7 = new List<int> { 1, 4, 3, 5, 7, 2, 10, 2, 5, 7 };

List<int> result;

Print(Task1(_dataTask1));
Print(Task2(_dataTask2));
Print(Task3(_dataTask3));
Print(Task4(_dataTask4));
Print(Task5(_dataTask5));
Print(Task6(_dataTask6));


Console.ReadLine();



static List<int> Task1(List<int> data) =>
    data.Where(x => x % 2 == 1)
        .Distinct()
        .ToList();

static List<int> Task2(List<int> data) =>
    data.Where(x => x > 0 && x.ToString().Length == 2)
        .OrderBy(x => x)
        .ToList();


static List<string> Task3(List<string> data) =>
    data.OrderBy(x => x.Length)
        .ThenBy(x => x)
        .ToList();



static List<char> Task4(List<string> data) =>
    data.Select(x => x[0])
    .Reverse()
    .ToList();




static List<int> Task5(List<int> data) =>
    data.Where(x => x > 0)
        .Select(x => x % 10)
        .Distinct()
        .ToList();


static List<int> Task6(List<int> data) =>
    data.Select((x, i) => i % 3 == 1 ? x * 2 : x)
        .Where((x, i) => i % 3 != 0)
        .ToList();




static List<int> Task7(List<int> dataA, List<int> dataB, int k1 = 6, int k2 = 4) =>
    dataA.Where(x => x > k1)
        .Concat(dataB.Where(x => x < k2))
        .OrderBy(x => x)
        .ToList();



static void Print<T>(List<T> data)
{
    foreach (var item in data)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
