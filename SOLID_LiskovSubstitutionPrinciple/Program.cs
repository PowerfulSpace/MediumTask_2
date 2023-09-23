
using SOLID_LiskovSubstitutionPrinciple.Models;

Account acc = new MicroAccount();
CalculateInterest(acc); // получаем 1100 без бонуса 100

Console.ReadLine();

static void CalculateInterest(Account account)
{
    decimal sum = account.GetInterest(1000, 1, 10); // 1000 + 1000 * 10 / 100 + 100 (бонус)
    if (sum != 1200) // ожидаем 1200
    {
        throw new Exception("Неожиданная сумма при вычислениях");
    }
}