

using BethanysPieShopHRM.HR;

namespace BethanysPieShopHRM
{

    internal class Utilities
    {
        private static string directory = @"D:\data\BethanysPieShopHRM\";
        private static string fileName = "employee.txt";
        internal static void RegisterEmployee(List<Employee> employees)
        {
            Console.WriteLine("Creating an employee...");
            Console.WriteLine("What type of employee do you want to register?");
            Console.WriteLine("1. Sales\n2. Manager\n3. Store manager\n4. Researcher");
            Console.Write("Your selection: ");
            string employeeType = Console.ReadLine();

            if (employeeType != "1" && employeeType != "2" && employeeType != "3" && employeeType != "4")
            {
                Console.WriteLine("Invalid selection!");
                return; // to exit 
            }
            Console.WriteLine("Enter the first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter the email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter the date of birth: ");
            string dateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hourly rate: ");
            string hourlyRate = Console.ReadLine();
            double rate = double.Parse(hourlyRate); // assume the input is in correct format

            Employee employee = null;

            switch (employeeType)
            {
                case "1":
                    employee = new Sales(firstName, lastName, email, dateOfBirth, rate);
                    break;
                case "2":
                    employee = new Manager(firstName, lastName, email, dateOfBirth, rate);
                    break;
                case "3":
                    employee = new StoreManager(firstName, lastName, email, dateOfBirth, rate);
                    break;
                case "4":
                    employee = new Researcher(firstName, lastName, email, dateOfBirth, rate);
                    break;

            }
            employees.Add(employee);
            Console.WriteLine("Employee created!\n\n");
        }
        internal static void CheckForExistingEmployeeFile()
        {
            //TODO: write code to check if file exists 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ResetColor();
        }
          internal static void ViewAllEmployees(List<Employee> employees)
        {
           for (int i = 0; i < employees.Count; i++)
            {
                employees[i].DisplayEmployeeDetails();
            }
        }
           internal static void SaveEmployees(List<Employee> employees)
        {
            //TODO: write code to save employees 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ResetColor();
        }
           internal static void LoadEmployees(List<Employee> employees)
        {
            //TODO: write code to load employees 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ResetColor();
        }
    }
}
