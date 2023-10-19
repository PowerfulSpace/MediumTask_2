//Дана целочисленная последовательность. Извлечь из нее все нечетные числа,
//сохранив их исходный порядок следования и удалив все вхождения повторяющихся элементов, кроме первых.

List<int> _dataTask1 = new List<int> { 3, 13, 12, 157, 14, 77, 75, 13, 200, 156, 14, 21 };
List<int> _dataTask2 = new List<int> { -12, -33, 134, 12, 1, -3, 99, 199, 5, 17, -121, 10 };
List<string> _dataTask3 = new List<string> { "ADJSLFKHJL", "FAJL", "ADJPLFKHJL", "FATL", "FD", "FAFADFSFDAFR", "FY" };
List<string> _dataTask4 = new List<string> { "asdf", "Rew", "trafa", "nadf", "Slos", "At", "new" };

List<int> result;

Print(Task1(_dataTask1));
Print(Task2(_dataTask2));
Print(Task3(_dataTask3));
Print(Task4(_dataTask4));


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



static void Print<T>(List<T> data)
{
    foreach (var item in data)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
