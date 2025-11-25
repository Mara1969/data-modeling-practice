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




