using System.Text;



static string VlcTrackInfo(int id, string name)
{
    var _id = id;

    Encoding utf8 = Encoding.UTF8;
    Encoding utf32 = Encoding.GetEncoding("UTF-32LE");
    byte[] text = Encoding.Convert(utf8, utf32, utf8.GetBytes(name));
    var _name = utf32.GetString(text);
    return _name;
}