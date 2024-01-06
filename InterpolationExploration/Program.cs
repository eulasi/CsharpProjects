﻿int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;
// Display the incoive number using string interpolation
Console.WriteLine($"Invoice Number: {invoiceNumber}");

// Display the product shares with one thousandth of a share (0.001) precision
Console.WriteLine($"    Shares: {productShares:N3} Product");
// Display the subtotal that you charge the customer formatted as currency
Console.WriteLine($"        Sub Total: {subtotal:C}");
// Display the tax charged on the sale formatted as a percentage
Console.WriteLine($"            Tax: {taxPercentage:P2}");
// Finalize the receipt with the total amount due formatted as currency
Console.WriteLine($"        Total Billed: {total:C}");

// Padding and Alignment Intermission
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12));

// Overloaded Method
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

// Adding payment ID to the output
string paymentId = "769C";
// Add the payee name to the output
string payeeName = "Mr. Stephen Ortega";
// Add the payment amount to the output
string paymentAmount = "$5,000.00";
var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);


