using SOLID_SingleResponsibilityPrinciple.Interfaces;

namespace SOLID_SingleResponsibilityPrinciple.Models
{
    class ConsolePhoneReader : IPhoneReader
    {
        public string?[] GetInputData()
        {
            Console.WriteLine("Введите модель:");
            string? model = Console.ReadLine();
            Console.WriteLine("Введите цену:");
            string? price = Console.ReadLine();
            return new string?[] { model, price };
        }
    }
}
