// Find parenthesis pairs embedded in a string
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// Remove openingPosition in output by skipping over the parenthesis character.
openingPosition += 1;

// retrieve the value between parenthesis
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

//Magic Values
string messageSpan = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingSpanPosition = message.IndexOf(openSpan);
int closingSpanPosition = message.IndexOf(closeSpan);

openingSpanPosition += openSpan.Length;
int length2 = closingSpanPosition - openingSpanPosition;
Console.WriteLine(messageSpan.Substring(openingSpanPosition, length));

