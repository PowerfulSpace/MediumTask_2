

var dateTime = DateTime.DaysInMonth(2023, 12);
int count = 0;

List<int> list = new List<int>();

for (int i = 1; i <= 12; i++)
{
    count = DateTime.DaysInMonth(2023, i);
    list.Add(count);
}
Console.WriteLine();
foreach (var item in list)
{
    Console.Write(item + " ");
}
Console.WriteLine();
var sum = list.Sum(x => x);
Console.WriteLine(sum);

Console.ReadLine();