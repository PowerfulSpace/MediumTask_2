Index myIndex1 = 2;     // третий элемент
Index myIndex2 = ^2;    // предпоследний элемент

string[] people = { "Tom", "Bob", "Sam", "Kate", "Alice" };
string selected1 = people[myIndex1];    // Sam
string selected2 = people[myIndex2];    // Kate
Console.WriteLine(selected1);
Console.WriteLine(selected2);

Console.ReadLine();