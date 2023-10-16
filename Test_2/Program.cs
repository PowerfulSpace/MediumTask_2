


string[] people = { "Tom", "Bob", "Sam", "Kate", "Alice" };
string[] peopleRange1 = people[^2..];       // два последних - Kate, Alice
string[] peopleRange2 = people[..^1];       // начиная с предпоследнего - Tom, Bob, Sam, Kate
string[] peopleRange3 = people[^3..^1];     // два начиная с предпоследнего - Sam, Kate

Console.ReadLine();

