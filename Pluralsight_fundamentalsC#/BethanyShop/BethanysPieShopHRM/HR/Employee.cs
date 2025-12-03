
using Newtonsoft.Json;  

namespace BethanysPieShopHRM.HR
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private string email;
        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyRate;
        private DateTime dateOfBirth;
        private const int minimalHoursWorkedUnit = 1;

        // private EmployeeType employeeType; // becomes data that we store on our class 
        private Address address; // Address class as a member of Employee class (has a relationship)

        public static double taxRate = 0.15; // static member belongs to the class itself rather than to any specific object

// properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWorked; }
            protected set { numberOfHoursWorked = value; } // protected set so it can only be changed within the class or derived classes
        }
        public double Wage
        {
            get { return wage; }
            private set { wage = value; }
        }
        public double? HourlyRate
        {
            get { return hourlyRate; }
            set 
            {   if (hourlyRate < 0)
                {
                    hourlyRate = 0;
                }
             else
                {
                   hourlyRate = value;
                }
            }
        }
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        /*public EmployeeType employeeType 
        { 
            get { return employeeType; }
             set { employeeType = value; }
        } */
// constructors
        public Employee(string firstName, string lastName, string email, DateTime dateOfBirth) : this(firstName, lastName, email, dateOfBirth, 0)
        {
            
        }
        public Employee(string firstName, string lastName, string email, DateTime dateOfBirth, double? hourlyRate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
            HourlyRate = hourlyRate ?? 20; // if Rate is null then assign 20
            //employeeType = empType;
        }
          public Employee(string firstName, string lastName, string email, DateTime dateOfBirth, double? hourlyRate, string street, string houseNumber, string city, string zipCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
            HourlyRate = hourlyRate ?? 20; 
            Address = new Address(street, houseNumber, city, zipCode); // initialize Address member
            
        }
        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit);
        }
        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName} {LastName} has worked for {NumberOfHoursWorked} hours.");
        }
        public double ReceiveWage(bool resetHours = true)
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;

            double taxAmount = wageBeforeTax * taxRate;
            wage = wageBeforeTax - taxAmount;   

            Console.WriteLine($"{FirstName} {LastName} has received a wage of {Wage} for {NumberOfHoursWorked} hours worked.");
            
            if (resetHours)
                NumberOfHoursWorked = 0; 
            
            return Wage;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{FirstName}\nLast name: \t{LastName}\nEmail: \t\t{Email}\nDate of Birth: \t{DateOfBirth.ToShortDateString()}\nTax rate: \t{taxRate}");
        }

        public int CalculateBonus(int bonus)
        {
            if (numberOfHoursWorked > 10)
                bonus *= 2;
            
            Console.WriteLine($"The employee got a bonus of: {bonus}");
            return bonus;
        }
        public virtual void GiveBonus() // virtual so derived classes can override
        {
            Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
        }

        /*public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        {
            if (NumberOfHoursWorked > 10)
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
            if (NumberOfHoursWorked > 10)
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
