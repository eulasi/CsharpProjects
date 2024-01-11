// Retrieve the last occurrence of a sub string
string message = "(What if) there are (more than) one (set of parenthesis)?";
// Retrieve all instances of substrings inside parentheses
while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    //Note the overload of the Substring to return only the remaning unprossed message:
    message = message.Substring(closingPosition + 1);

}

Console.WriteLine("-------------------");

// Working with different types of symbol sets
string message2 = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 6;
int openingPositionSym = message2.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message2.Substring(openingPositionSym)}");

openingPositionSym = message2.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}: {message2.Substring(openingPositionSym)}");

string message3 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. You want to look for:
char[] openSymbolsMatch = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through the characters in the string. This time, use the closing position of the previous iteration as the starting index for the next open symbol. So, you need to initialize the closingPosition variable to zero:

int closingPositionMatch = 0;

while (true)
{
    int openingPositionMatch = message3.IndexOfAny(openSymbolsMatch, closingPositionMatch);

    if (openingPositionMatch == -1) break;

    string currentSymbol = message3.Substring(openingPositionMatch, 1);

    // Now find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify  that the search for the matchingSymbol should start at the openingPosition in the string.
    openingPositionMatch += 1;
    closingPositionMatch = message3.IndexOf(matchingSymbol, openingPositionMatch);

    // Finally, use the techniques you've already learned to display the sub-string:
    int lengthMatch = closingPositionMatch - openingPositionMatch;
    Console.WriteLine(message3.Substring(openingPositionMatch, lengthMatch));

}