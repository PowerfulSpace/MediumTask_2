//Дана целочисленная последовательность. Извлечь из нее все нечетные числа,
//сохранив их исходный порядок следования и удалив все вхождения повторяющихся элементов, кроме первых.

List<int> _dataTask1 = new List<int> { 3, 13, 12, 157, 14, 77, 75, 13, 200, 156, 14, 21 };
List<int> result;

Print(_dataTask1);

result = Task1(_dataTask1);

Print(result);


Console.ReadLine();



static List<int> Task1(List<int> data) =>
    data.Where(x => x % 2 == 1)
        .Distinct()
        .ToList();



static void Print(List<int> data)
{
    foreach (var item in data)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
