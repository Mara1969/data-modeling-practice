// See https://aka.ms/new-console-template for more information

/* A program for Bethanys Pie shop, where a user can enter
employee details. When entering the details, the app should
ask the user for the age of the employee, 
and if the employee is under 18, we can't hire them 
and the app should display a message.
If the employee is above 65, a message should be displayed 
to say we can't hire them. */

Console.WriteLine("Welcome to Bethany's Pie Shop HRM!");

Console.WriteLine("Please enter your name: ");
string userName = Console.ReadLine();

Console.WriteLine("Please enter your age: ");
int userAge = int.Parse(Console.ReadLine());

/*
if (userAge < 18)
{
    Console.WriteLine("Sorry, you are too young to apply.");
}
else if (userAge > 65)
{
    Console.WriteLine("Sorry, you cannot apply.");
}
else
{
    Console.WriteLine("Great, you can now start with the application!");
}

*/
// using a switch statement
switch (userAge)
{
    case < 18:
        Console.WriteLine("Sorry, you are too young to apply.");
        break;
    case > 65:
        Console.WriteLine("Sorry, you cannot apply.");
        break;
    case 42:
        Console.WriteLine("Ah! Exactly what we are looking for.");
        break;
    default:
        Console.WriteLine("Great, you can now start with the application!");
        break;
}
