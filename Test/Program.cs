
using System.Net;

var googleEntry = await Dns.GetHostEntryAsync("google.com");
Console.WriteLine(googleEntry.HostName);

foreach (var ip in googleEntry.AddressList)
{
    Console.WriteLine(ip);
}

Console.ReadLine();