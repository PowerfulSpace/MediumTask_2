
using System.Security.Cryptography;
using System.Text;

string input = "Hello, World"; //входное сообщение
string output; //дайджест сообщения (хэш)
MD5 MD5Hash = MD5.Create(); //создаем объект для работы с MD5
byte[] inputBytes = Encoding.ASCII.GetBytes(input); //преобразуем строку в массив байтов
byte[] hash = MD5Hash.ComputeHash(inputBytes); //получаем хэш в виде массива байтов
output = Convert.ToHexString(hash); //преобразуем хэш из массива в строку, состоящую из шестнадцатеричных символов в верхнем регистре

Console.WriteLine(output);