using System;

namespace BethanysPieShopHRM
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;
        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;
        public DateTime dateOfBirth;
        const int minimalHoursWorkedUnit = 1;
        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit);
        }
        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hours.");
        }
        public double ReceiveWage(bool resetHours = true)
        {
            wage = numberOfHoursWorked * hourlyRate;
            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hours worked.");
            
            if (resetHours)
                numberOfHoursWorked = 0; 
            
            return wage;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFist name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\nDate of Birth: \t{dateOfBirth.ToShortDateString()}");
        }
    }
}
