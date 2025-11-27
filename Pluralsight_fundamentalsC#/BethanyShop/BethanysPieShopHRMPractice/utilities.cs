namespace BethanysPieShopHRMPractice
{
    internal class  Utilities
    {
        public static void UsingOptionalParameters()
        {
            int monthlyWage1 = 1000;
            int numberOfMonthsWorked1 = 12;

            int yearlyWage1 = CalculateYearlyWageWithOptional(monthlyWage1, numberOfMonthsWorked1, 100);
            Console.WriteLine($"Yearly wage for employee 1: {yearlyWage1}");
        }
        public static int CalculateYearlyWageWithOptional(int monthlyWage, int numberOfMonthsWorked, int bonus = 0) // bonus is an optional parameter
        {
            Console.WriteLine($"The yearly mwage is: {monthlyWage * numberOfMonthsWorked + bonus}");
             return monthlyWage * numberOfMonthsWorked + bonus;
        }
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            if (numberOfMonthsWorked == 12) // add a bonus month 
                return monthlyWage * (numberOfMonthsWorked + 1);
             return monthlyWage * numberOfMonthsWorked;
        }
        public static int CalculateYearlyWageExpressionBodied(int monthlyWage, int numberOfMonthsWorked, int bonus) =>
            monthlyWage * numberOfMonthsWorked + bonus;
        
        public static void ManipulatingStrings()
        {
            string firstName = "Bethany";
            string lastName = "Smith";

            string fullName = string.Concat(firstName, " ", lastName);
            string empID = firstName.ToLower() + "-" + lastName.Trim().ToLower();
            int length = empID.Length;

            string subString = fullName.Substring(1, 3);
            Console.WriteLine($"Characters from index 1 to 3: {subString}");

        }
        public static void UsingEscapeSequences()
        {
            string filePath = "C:\\Users\\Bethany\\Documents\\EmployeeData.txt";
            string verbatimFilePath = @"C:\Users\Bethany\Documents\EmployeeData.txt";

            Console.WriteLine($"File Path using escape sequences: {filePath}");
            Console.WriteLine($"File Path using verbatim string: {verbatimFilePath}");
        }

        public static void UsingStringEquality()
        {
            string name1 = "Bethany";
            string name2 = "BETHANY";

            Console.WriteLine($"Are both names equal? {name1 == name2}"); 
            Console.WriteLine($"Are both names equal (case-insensitive)? {name1.ToLower().Equals(name2.ToLower())}");           
        }
        
        public static void ParsingStrings()
        {
            Console.WriteLine("Enter your wage: ");
            string wageInput = Console.ReadLine();

            if (int.TryParse(wageInput, out int wage))
            {
                Console.WriteLine($"Your wage is: {wage}");
            }
            else
            {
                Console.WriteLine("Invalid wage input.");
            }
        }
    }
}
    