// See https://aka.ms/new-console-template for more information
string a = "String Tutorial";
Console.WriteLine(a);  //show string
Console.WriteLine(a.Length); //string length count
Console.WriteLine(a.IndexOf('u')); //index of u

// Insert(index, value) inserting text
a = a.Insert(0, "Wow!, much cool ");
Console.WriteLine(a);

//Replace a string char
a = a.Replace("Wow", "Nice");
Console.WriteLine(a);

//Search a string literal "T" if it in the string, says found it
if (a.Contains("T"))
    Console.WriteLine("Found It");

//Remove all string characters from the specified string index position
a = a.Remove(5);
Console.WriteLine(a);

//Substring(index, length) returns a substring of the specified length, starting from the specified index
//If length is not defined, the operation continues to the end of the string

a = a.Substring(1);
Console.WriteLine(a);