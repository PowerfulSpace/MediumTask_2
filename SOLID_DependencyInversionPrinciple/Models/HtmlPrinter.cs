using SOLID_DependencyInversionPrinciple.Models.Base;

namespace SOLID_DependencyInversionPrinciple.Models
{
    class HtmlPrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Печать в html");
        }
    }
}
