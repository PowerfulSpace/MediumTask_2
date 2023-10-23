

List<int> _dataTask6 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

var quare = _dataTask6
    .Select(x => x % 3 == 1 ? x * 2 : x)
    .Where(x => x % 3 != 0)
    .ToList();


foreach (var item in _dataTask6)
{
    Console.Write(item + " ");
}
Console.WriteLine();
foreach (var item in quare)
{
    Console.Write(item + " ");
}


Console.ReadLine();


