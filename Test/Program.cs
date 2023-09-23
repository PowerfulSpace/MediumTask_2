

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

class Account
{
    public virtual decimal GetInterest(decimal sum, int month, int rate)
    {
        // предусловие
        if (sum < 0 || month > 12 || month < 1 || rate < 0)
            throw new Exception("Некорректные данные");

        decimal result = sum;
        for (int i = 0; i < month; i++)
            result += result * rate / 100;

        // постусловие
        if (sum >= 1000)
            result += 100; // добавляем бонус

        return result;
    }
}

class MicroAccount : Account
{
    public override decimal GetInterest(decimal sum, int month, int rate)
    {
        if (sum < 0 || month > 12 || month < 1 || rate < 0)
            throw new Exception("Некорректные данные");

        decimal result = sum;
        for (int i = 0; i < month; i++)
            result += result * rate / 100;

        return result;
    }
}

