using SOLID_DependencyInversionPrinciple.Models.Base;

namespace SOLID_DependencyInversionPrinciple.Models
{
    class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Печать на консоли");
        }
    }
}
