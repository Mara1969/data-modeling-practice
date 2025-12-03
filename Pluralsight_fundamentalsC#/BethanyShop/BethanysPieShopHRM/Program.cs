using System.Text;
using BethanysPieShopHRM.Accounting;
using BethanysPieShopHRM.HR;


Console.WriteLine("Creating an employee!");
Console.WriteLine("------------------\n");

Employee employee1 = new("Bethany", "Smith", "bethany.smith@hotmail.com", new DateTime(1990, 5, 23), 25);

Manager manager1 = new("Alice", "Johnson", "alice.johnson@hotmail.com", new DateTime(1985, 8, 12), 40);

employee1.DisplayEmployeeDetails();
manager1.DisplayEmployeeDetails();
manager1.PerformWork(25);
manager1.ReceiveWage();

manager1.AttendManagementMeeting();
// employee1.attendManagementMeeting(); will cause compile error since Employee class does not have this method

Employee employee2 = new Employee("Jake", "Nicols", "jake@snowball.com"

/* Employee employee2 = new("John", "Doe", "john.doe@hotmail,com", new DateTime(1989, 1, 15), 30);
Employee employee3 = new("Kevin", "Jones", "john.doe@hotmail,com", new DateTime(1969, 2, 15), 30);
Employee employee4 = new("Kim", "Dodds", "john.doe@hotmail,com", new DateTime(1992, 7, 15), 30);

Employee[] employees = new Employee[4] { employee1,  employee2, employee3, employee4 };

foreach (Employee emp in employees)
{
    emp.DisplayEmployeeDetails();
    var numberOfHoursWorked = new Random().Next(25); // generate random number between 0 and 24
    emp.PerformWork(numberOfHoursWorked);
    emp.ReceiveWage();
}

employee1.FirstName = "Jane";
string empFirstName = employee1.FirstName;

employee1.PerformWork(25);

int minimumBonus = 100;
int bonusTax; // if using ref then this needs to be initialized first
int receivedBonus = employee1.CalculateBonusAndBonusTax(minimumBonus, out bonusTax); // out can be changed to ref
Console.WriteLine($"Minimum bonus was: {minimumBonus}, {employee1.firstName} received a bonus of: {receivedBonus}, and bonus tax is: {bonusTax}");

StringBuilder sb = new StringBuilder();
sb.Append("Last name: ");
sb.AppendLine(employee1.lastName);
sb.AppendLine("First name: ");
sb.AppendLine(employee1.firstName);
string result = sb.ToString();

Console.WriteLine(result);


int minimumBonus = 100;
int receivedBonus = employee1.CalculateBonus(minimumBonus);
Console.WriteLine($"Minimum bonus was: {minimumBonus} and {employee1.firstName} received a bonus of: {receivedBonus}");


Employee testemployee = employee1; // testemployee references the same object as employee1

testemployee.DisplayEmployeeDetails();
employee1.DisplayEmployeeDetails();

employee1.hourlyRate = 10;
employee1.PerformWork(25);
double employee1Wage = employee1.ReceiveWage(true);

Console.WriteLine("Creating an employee!");
Console.WriteLine("------------------\n");

Employee employee2 = new("John", "Doe", "john.doe@hotmail,com", new DateTime(1985, 3, 15), 30, EmployeeType.Sales);
employee2.DisplayEmployeeDetails();
employee2.PerformWork(4);
double employee2Wage = employee2.ReceiveWage(false);

WorkTask task1; // can use new to initialize struct but its not required since it is a value type
task1.description = "Baking pies";
task1.hours = 2;
task1.PerformWorkTask();
    
Customer customer1 = new Customer(); */

