




Console.ReadLine();



static bool IsAcceptable(int id, int absLimit) =>
    SimulateDataFetch(id) is var results
    && results.Min() >= -absLimit
    && results.Max() <= absLimit;

static int[] SimulateDataFetch(int id)
{
    var rand = new Random();
    return Enumerable
               .Range(start: 0, count: 5)
               .Select(s => rand.Next(minValue: -10, maxValue: 11))
               .ToArray();
}
