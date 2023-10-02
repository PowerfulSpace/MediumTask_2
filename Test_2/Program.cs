


DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
DateTime date2 = new DateTime(2010, 8, 18, 13, 30, 30);


TimeSpan interval = date2 - date1;
Console.WriteLine("{0} - {1} = {2}", date2, date1, interval.ToString());


Console.WriteLine("   {0,-35} {1,20}", "Value of Days Component:", interval.Days);
Console.WriteLine("   {0,-35} {1,20}", "Total Number of Days:", interval.TotalDays);
Console.WriteLine("   {0,-35} {1,20}", "Value of Hours Component:", interval.Hours);
Console.WriteLine("   {0,-35} {1,20}", "Total Number of Hours:", interval.TotalHours);
Console.WriteLine("   {0,-35} {1,20}", "Value of Minutes Component:", interval.Minutes);
Console.WriteLine("   {0,-35} {1,20}", "Total Number of Minutes:", interval.TotalMinutes);
Console.WriteLine("   {0,-35} {1,20:N0}", "Value of Seconds Component:", interval.Seconds);
Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Seconds:", interval.TotalSeconds);
Console.WriteLine("   {0,-35} {1,20:N0}", "Value of Milliseconds Component:", interval.Milliseconds);
Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Milliseconds:", interval.TotalMilliseconds);
Console.WriteLine("   {0,-35} {1,20:N0}", "Ticks:", interval.Ticks);

Console.ReadLine();