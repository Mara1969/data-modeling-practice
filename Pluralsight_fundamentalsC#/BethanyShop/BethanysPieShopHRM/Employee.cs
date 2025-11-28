
using Newtonsoft.Json;  

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

        public EmployeeType employeeType; // becomes data that we store on our class 

        public Employee(string first, string last, string em, DateTime dob) : this(first, last, em, dob, 0, EmployeeType.Researcher)
        {
            
        }
        public Employee(string first, string last, string em, DateTime dob, double Rate, EmployeeType empType)
        {
            firstName = first;
            lastName = last;
            email = em;
            dateOfBirth = dob;
            hourlyRate = Rate;
            employeeType = empType;
        }
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
            if (employeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"An extra was added to the wage since {firstName} is a manager.");
                wage = numberOfHoursWorked * hourlyRate * 1.25;
            }
            else
            {
                wage = numberOfHoursWorked * hourlyRate;
            }
            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hours worked.");
            
            if (resetHours)
                numberOfHoursWorked = 0; 
            
            return wage;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFist name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\nDate of Birth: \t{dateOfBirth.ToShortDateString()}");
        }
        
        public int CalculateBonus(int bonus)
        {
            if (numberOfHoursWorked > 10)
                bonus *= 2;
            
            Console.WriteLine($"The employee got a bonus of: {bonus}");
            return bonus;
        }

        /*public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        {
            if (numberOfHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10; // 10% tax on bonus
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of: {bonus} with a tax of: {bonusTax}");
            return bonus;
        }*/
        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (numberOfHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10; // 10% tax on bonus
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of: {bonus} with a tax of: {bonusTax}");
            return bonus;
        }

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
    }
}
