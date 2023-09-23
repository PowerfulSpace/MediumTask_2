





Console.ReadLine();




class Phone
{
    public string Model { get; }
    public int Price { get; }
    public Phone(string model, int price)
    {
        Model = model;
        Price = price;
    }
}

class MobileStore
{
    List<Phone> phones = new();
    public void Process()
    {
        // ввод данных
        Console.WriteLine("Введите модель:");
        string? model = Console.ReadLine();
        Console.WriteLine("Введите цену:");

        // валидация
        bool result = int.TryParse(Console.ReadLine(), out var price);

        if (result == false || price <= 0 || string.IsNullOrEmpty(model))
        {
            throw new Exception("Некорректно введены данные");
        }
        else
        {
            phones.Add(new Phone(model, price));
            // сохраняем данные в файл
            using (StreamWriter writer = new StreamWriter("store.txt", true))
            {
                writer.WriteLine(model);
                writer.WriteLine(price);
            }
            Console.WriteLine("Данные успешно обработаны");
        }
    }
}