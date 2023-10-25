




class Reader
{
    Lazy<Library> library = new Lazy<Library>();
    public void ReadBook()
    {
        library.Value.GetBook();
        Console.WriteLine("Читаем бумажную книгу");
    }

    public void ReadEbook()
    {
        Console.WriteLine("Читаем книгу на компьютере");
    }
}

class Library
{
    private string[] books = new string[99];

    public void GetBook()
    {
        Console.WriteLine("Выдаем книгу читателю");
    }
}