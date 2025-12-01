Console.WriteLine("Welcome to Bethany's Pie Shop HRM!");

Console.WriteLine("Please enter your name: ");


string name = Console.ReadLine();

var monthlyWage = 1234;
int months = 12, bonus = 1000; 

var isActive = true;

var rating = 99.25;

var numberOfEmployees = 300;

int hoursWorked;
hoursWorked = 125;
hoursWorked = 148; 

const double interestRate = 0.07;

//interestRate = 0.08;

string firstName = "Bethany";
string lastName = "Smith";
string emptyString = ""; 

double ratePerHour = 12.34;

int numberOfHoursWorked = 165;

double currentMonthWage = ratePerHour * numberOfHoursWorked;
Console.WriteLine(currentMonthWage);

ratePerHour += 3;
Console.WriteLine(ratePerHour);

if(currentMonthWage > 2000)
    Console.WriteLine("Top paid employee!");

int numberOfEmployees = 15;
numberOfEmployees--; 
Console.WriteLine(numberOfEmployees);

char userSelection = 'a';
char upperVersion = char.ToUpper(userSelection);
Console.WriteLine(upperVersion);

bool isDigit = char.IsDigit(userSelection);
bool isLetter = char.IsLetter(userSelection);

DateTime hireDate = new DateTime(2022, 3, 28, 14, 30, 0);
Console.WriteLine(hireDate);

DateTime exitDate = new DateTime(2025, 12, 11);
Console.WriteLine(exitDate);

DateTime starDate = hireDate.AddDays(15);
Console.WriteLine(starDate);

DateTime currentDate = DateTime.Now;
bool areWeInDST = currentDate.IsDaylightSavingTime();

DateTime startHour = DateTime.Now;
TimeSpan workTime = new TimeSpan(8, 25, 0);
DateTime endHour = startHour.Add(workTime);

Console.WriteLine(startHour.ToLongDateString()); // e.g., Monday, 3 Januaru, 2022
Console.WriteLine(endHour.ToShortTimeString()); // e.g., 22:17 */

long veryLongMonth = numberOfHoursWorked;
double d = 12345.0;
int x = (int)d; // can create data loss

int age = 23;
bool a = age ==23;

Console.WriteLine("Age is 23: " + a);

bool b = age >= 23;
Console.WriteLine("Age is greater than or equal to 23: " + b);
bool c = (age >= 18) && (age <= 65); // && is the and oeprator, || is the or operator
Console.WriteLine("Age is between 18 and 65: " + c); // this will return true

Console.WriteLine("Enter a value: ");
int max = int.Parse(Console.ReadLine());
int count = 0;

while (count < max)
{
    Console.WriteLine(i);
    count++;
}


Console.WriteLine("Loop finished.");

/* A program for Bethanys Pie shop, where a user can enter
employee details. When entering the details, the app should
ask the user for the age of the employee, 
and if the employee is under 18, we can't hire them 
and the app should display a message.
If the employee is above 65, a message should be displayed 
to say we can't hire them. */


/*Console.WriteLine("Please enter your name: ");
string userName = Console.ReadLine();

Console.WriteLine("Please enter your age: "); 
int userAge = int.Parse(Console.ReadLine());


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
*/ 

int[] sampleAray1 = new int[5]; // array of 5 integers
int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5 }; // array of 5 integers initialized with values

int length = int.Parse(Console.ReadLine());

for (int i = 0; i < length; i++)
{
    Console.Write("Enter the employee ID:");
    int id = int.Parse(Console.ReadLine());
    employeeIDs[i] = id;
}
