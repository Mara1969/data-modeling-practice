

using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Text;
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
            Console.WriteLine("1. Employee\n2. Manager\n3. Store manager\n4. Researcher");
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
                    employee = new Employee(firstName, lastName, email, dateOfBirth, rate);
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
            string path = directory + fileName;
            bool existingFileFound = File.Exists(path);
            
            if (existingFileFound)
            {
                Console.WriteLine("An existing file with Employee data is found");
            }
            else
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Directory is ready for saving files.");
                    Console.ResetColor();
                }    
            }

            
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
            string path = directory + fileName;
            StringBuilder sb = new StringBuilder();
            foreach (Employee employee in employees)
            {
                string typeOfEmployee = GetEmployeeType(employee);
                sb.Append($"firstName: {employee.FirstName};");
                sb.Append($"lastName: {employee.LastName};");
                sb.Append($"email: {employee.Email};");
                sb.Append($"dateOfBirth: {employee.DateOfBirth};");
                sb.Append($"hourlyRate: {employee.HourlyRate};");
                sb.Append($"{typeOfEmployee};");

                sb.Append(Environment.NewLine); // add a new line so each employee will be on one line in the file 
            }
            File.WriteAllText(path, sb.ToString()); 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saved employees successfully.");
            Console.ResetColor();

           
        }

        private static string GetEmployeeType(Employee employee)
        {
            if (employee is Manager)
                return "2";
            else if (employee is StoreManager)
                return "3";
            else if (employee is Employee)
                return "4";
            else if (employee is Researcher)
                return "5";
            else
                return "0";
        }
           internal static void LoadEmployees(List<Employee> employees)
        {
            string path = directory + fileName;
            bool existingFileFound = File.Exists(path);
            try 
            {
                if (existingFileFound)
                {
                    employees.Clear(); // clear the employees already loaded in the memory of the application 

                    // read the file 
                    string[] employeesAsString = File.ReadAllLines(path); // creating a string array 
                    for (int i = 0; i < employeesAsString.Length; i++)
                    {
                        string[] employeeSplits = employeesAsString[i].Split(';'); // split the line based on the delimeter ';' to return an array 
                        string firstName = employeeSplits[0].Substring(employeeSplits[0].IndexOf(':') + 1); // The result of employeeSplits[0] is this 'firstName:Bethany' and 'Substring' takes the part of this from ':' + 1 hence firstname only 
                        string lastName = employeeSplits[1].Substring(employeeSplits[1].IndexOf(':') + 1);
                        string email = employeeSplits[2].Substring(employeeSplits[2].IndexOf(':') + 1);
                        DateTime dateOfBirth = DateTime.Parse(employeeSplits[3].Substring(employeeSplits[3].IndexOf(':') + 1));
                        double hourlyRate = double.Parse(employeeSplits[4].Substring(employeeSplits[4].IndexOf(':') + 1));
                        string employeeType = employeeSplits[5].Substring(employeeSplits[5].IndexOf(':') + 1);

                        Employee employee = null;
                        switch(employeeType)
                        {
                            case "1":
                                employee = new Employee(firstName, lastName, email, dateOfBirth, hourlyRate);
                                break;
                            case "2":
                                employee = new Manager(firstName, lastName, email, dateOfBirth, hourlyRate);
                                break;
                            case "3":
                                employee = new StoreManager(firstName, lastName, email, dateOfBirth, hourlyRate);
                                break;
                            case "4":
                                employee = new Researcher(firstName, lastName, email, dateOfBirth, hourlyRate);
                            break;
                        }
                        employees.Add(employee);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Loaded {employees.Count} employees!\n\n");
                    //Console.ResetColor();
                }
            }    
            catch (IndexOutOfRangeException iex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong parsing the file, please check the data!");
                Console.WriteLine(iex.Message);
                //Console.ResetColor();
                    
                
            }
            catch(FileNotFoundException fnfex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The file couldn't be found!");
                Console.WriteLine(fnfex.Message);
                Console.WriteLine(fnfex.StackTrace); // to show where the exception occured 
                //Console.ResetColor();
            }
            // catch any other exception 
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
               // Console.ResetColor();
            }
            finally
            {
                Console.ResetColor();
            }
        
        }
        internal static void LoadEmployeeById(List<Employee> employees)
        {
            Console.WriteLine("Enter the employee ID you want to visualise: ");

            try
            {
                int selectedID = int.Parse(Console.ReadLine());
                Employee selectedEmployee = employees[selectedID];
                selectedEmployee.DisplayEmployeeDetails();
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message); // writes the exception message 
            }
        }

    }
}
