namespace BethanysPieShopHRM.HR;

internal class Sales : Employee
{
    // constructors
    public Sales(string firstName, string lastName, string email, DateTime dateOfBirth, double? hourlyRate) : base(firstName, lastName, email, dateOfBirth, hourlyRate) // call base class constructor from employee
    {
    }
}
