Console.WriteLine("Evaluating a & a");
Console.WriteLine("a" == "a");
Console.WriteLine("Evaluating a & A");
Console.WriteLine("a" == "A");
Console.WriteLine("Evaluating 1 & 2");
Console.WriteLine(1==2);
Console.WriteLine("Evaluating a & myValue Variable");
string myValue = "a";
Console.WriteLine(myValue == "a");
Console.WriteLine("Evaluating strings with spaces");
string value1 = " a";
string value2 = "A ";
// Removing spaces and changing cases
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue2 = "a";
Console.WriteLine(myValue2 != "a");

// Comparison operators
Console.WriteLine(1>2);
Console.WriteLine(1<2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

Console.WriteLine("Pangram Comparison");
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
