
using SOLID_DependencyInversionPrinciple.Models;



Book book = new Book(new ConsolePrinter());
book.Print();
book.Printer = new HtmlPrinter();
book.Print();

Console.ReadLine();