// See https://aka.ms/new-console-template for more information


using BethanysPieShopHRM;

Console.WriteLine("Welcome to Bethany's Pie Shop HRM!");

string userChoice;
do
{   Console.WriteLine("Choose the action you want to perform:");
    Console.WriteLine("1. Add new employee");
    Console.WriteLine("2. Update employee");
    Console.WriteLine("3. Delete employee");
    Console.WriteLine("4. Exit application"); 
    userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "1":
            Console.WriteLine("You chose to add a new employee.");
            break;
        case "2":
            Console.WriteLine("You chose to update an employee.");
            break;
        case "3":
            Console.WriteLine("You chose to delete an employee.");
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }

} while (userChoice != "4");

Console.WriteLine("Exiting application. Goodbye!");

int amount = 1234; 
int months = 12;
int yearlWage = Utilities.CalculateYearlyWage(amount, months);
Console.WriteLine($"Yearly wage is: {yearlWage}");

Console.ReadLine();



