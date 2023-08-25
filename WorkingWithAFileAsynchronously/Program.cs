


var streamRecording = new FileStream(@"D:\Testing\Test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
byte[] arrayRecording = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
streamRecording.BeginWrite(arrayRecording, 0, arrayRecording.Length, new AsyncCallback(CleanUp), streamRecording);


var stream = new FileStream(@"D:\Testing\Test.txt", FileMode.Open, FileAccess.Read);
var array = new byte[stream.Length];
IAsyncResult asyncResult = stream.BeginRead(array, 0, array.Length, null, null);

Console.WriteLine("Чтение файла ...");
stream.EndRead(asyncResult);

foreach (byte item in array)
    Console.Write(item + " ");

stream.Close();

Console.ReadKey();


static void CleanUp(IAsyncResult asyncResult)
{
    Console.WriteLine("Файл записан.");
    var stream = asyncResult.AsyncState as FileStream;

    if (stream != null)
        stream.Close();
}
