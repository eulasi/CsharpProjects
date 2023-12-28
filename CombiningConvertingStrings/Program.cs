string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string alpha = "";
decimal vals = 0m;

foreach (var value in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number)) 
    {
        vals += number;
    } else {
        alpha += value;
    }

}

Console.WriteLine ($"Message: {alpha}");
Console.WriteLine ($"{vals}");
