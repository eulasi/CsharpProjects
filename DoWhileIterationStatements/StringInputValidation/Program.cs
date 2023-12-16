string? readResult;
string valueEntered = "";
bool validEntry = false;

do
{
    Console.WriteLine($"Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();

    if (readResult != null)
    {
        valueEntered = readResult.Trim();
    }

    if (valueEntered.ToLower() == "administrator" || valueEntered.ToLower() == "manager" || valueEntered.ToLower() == "user")
    {
        validEntry = true;
    }
    else
    {
        Console.WriteLine($"The role name that you entered. \"{valueEntered}\" is not valid. Enter your role (Administrator, Manager, or User) ");
    }

} while (validEntry == false);

Console.WriteLine($"You input value ({valueEntered}) has been accepted.");
readResult = Console.ReadLine();

