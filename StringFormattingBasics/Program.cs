// Composite Formatting
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

// Example Two
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

// String Interpolation
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

// Formatting Currency
decimal price = 123.45m;
int discount = 50;
// add C: for the dollar sign 
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// Formatting Numbers
decimal measurement = 123456.78912m;
// First Two Digits after the decimal point
Console.WriteLine($"Mesaurement: {measurement:N} units");
// First Four Digits after the decimal point
Console.WriteLine($"Measurement: {measurement:N4} units");

// Formatting percentages
decimal tax = .36785m;
// P2 for percent sign
Console.WriteLine($"Tax rate: {tax:P2}");

// Combining formatting approaches
decimal priceTwo = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (priceTwo - salePrice), priceTwo);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; // inserted
Console.WriteLine(yourDiscount);

