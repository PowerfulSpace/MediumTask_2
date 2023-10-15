//Дана целочисленная последовательность. Извлечь из нее все нечетные числа,
//сохранив их исходный порядок следования и удалив все вхождения повторяющихся элементов, кроме первых.

int[] array = new int[] { 8, 1, 4, 7, 9, 2, 1, 8, 2, 5, 1, 9, 6, 3, 10, 5 };


var q = array.Where(x => x % 2 != 0).Distinct();

var a = from x in array
        where x % 2 != 0
        select x;

var b = a.Intersect(array);


foreach (var x in q)
{
    Console.Write(x + " ");
}



Console.ReadLine();

List<int> _dataTask1 = new List<int> { 3, 13, 12, 157, 14, 77, 75, 13, 200, 156, 14, 21 };

static List<int> Task1(List<int> data) =>
    data.Where(x => x % 2 == 1)
        .Distinct()
        .ToList();