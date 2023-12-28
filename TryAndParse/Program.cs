// TryParse() a string into an int
string value = "102"; // edit for testing
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Mesaurement: {result}");
}
else 
{
    Console.WriteLine("Unable to report the mesurement.");
}

Console.WriteLine($"Mesaurement (w/ offset): {50 + result}");
