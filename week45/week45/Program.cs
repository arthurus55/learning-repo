
Console.Write("Welcome to Formula 1, future Champion! Please enter your name: ");
string driverName = Console.ReadLine() ?? "";

int driverNumber = 0;

while (true)
{
    Console.Write($"Welcome to the grid, {driverName}. Please choose a number from 2 to 99: ");

    if (!int.TryParse(Console.ReadLine(), out driverNumber))
    {
        Console.WriteLine("Invalid input! Please enter a whole number.");
        continue;
    }

    if (driverNumber == 1)
    {
        Console.WriteLine("Sorry, number 1 is reserved for the reigning world champion.");

        Console.Write("Enter the secret champion message to override: ");
        string secretMessage = Console.ReadLine() ?? "";

        if (secretMessage == "I am the reigning world champion")
        {
            Console.WriteLine("Sorry for the mistake, Lando. Best of luck next race weekend, NOR1!");
            break;
        }
        else
        {
            Console.WriteLine("Incorrect message! Please choose another number.");
        }
    }
    else if (driverNumber == 17)
    {
        Console.WriteLine("Number 17 is retired in honor of Jules Bianchi. Try again!");
    }
    else if (driverNumber < 2 || driverNumber > 99)
    {
        Console.WriteLine("Invalid number! Please choose a number from 2 to 99.");
    }
    else
    {
        string driverCode = driverName[..Math.Min(3, driverName.Length)].ToUpper();

        Console.WriteLine($"Copy that! Best of luck next race weekend, {driverCode}{driverNumber}!");
        break;
    }
}
