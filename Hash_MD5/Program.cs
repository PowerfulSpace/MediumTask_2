
using System.Security.Cryptography;
using System.Text;

string input = "Hello, World"; //входное сообщение
string output; //дайджест сообщения (хэш)

Console.WriteLine("MD5");
output = CreateMD5(input);
Console.WriteLine(output+"\n");


Console.WriteLine("SHA256");
output = CreateSHA256(input);
Console.WriteLine(output + "\n");

Console.ReadLine();

static string CreateMD5(string input)
{
    using MD5 hashMD56 = MD5.Create();                      //создаем объект для работы с MD5

    var inputBytes = Encoding.ASCII.GetBytes(input);        //преобразуем строку в массив байтов
    var hash = hashMD56.ComputeHash(inputBytes);            //получаем хэш в виде массива байтов
    var output = Convert.ToHexString(hash);                 //преобразуем хэш из массива в строку, состоящую из шестнадцатеричных символов в верхнем регистре
    return output;
}


static string CreateSHA256(string input)
{
    using SHA256 hashSHA256 = SHA256.Create();

    var inputBytes = Encoding.ASCII.GetBytes(input);
    var hash = hashSHA256.ComputeHash(inputBytes);
    var output = Convert.ToHexString(hash);
    return output;
}