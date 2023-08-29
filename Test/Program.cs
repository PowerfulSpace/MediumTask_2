class Program
{
    static void Main(string[] args)
    {
        const int nameColumn = 1;
        const int countryColumn = 8;
        const int elevationColumn = 15;

        String inFile = "Data/AllCountries.txt";
        if (args.Length >= 1) inFile = args[0];

        int degreeOfParallelism = 1;
        if (args.Length >= 2) degreeOfParallelism = int.Parse(args[1]);
        Console.WriteLine("Geographical data file: {0}. 
    
          Degree of Parallelism: { 1}.", inFile, degreeOfParallelism);
  
    var lines = File.ReadLines(Path.Combine(
      Environment.CurrentDirectory, inFile));

        var q = from line in
          lines.AsParallel().WithDegreeOfParallelism(degreeOfParallelism)
                let elevation =
                  Helper.ExtractIntegerField(line, elevationColumn)
                where elevation > 8000 // elevation in meters
                orderby elevation descending
                select new
                {
                    elevation = elevation,
                    thisLine = line
                };

        foreach (var x in q)
        {
            if (x != null)
            {
                String[] fields = x.thisLine.Split(new char[] { '\t' });
                Console.WriteLine("{0} ({1}m) - located in {2}",
                  fields[nameColumn], fields[elevationColumn],
                  fields[countryColumn]);
            }
        }
    }
}