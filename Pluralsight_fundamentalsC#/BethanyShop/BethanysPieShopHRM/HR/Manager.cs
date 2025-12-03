    using System;

namespace BethanysPieShopHRM.HR;

internal class Manager : Employee
{
    // constructors
    public Manager(string firstName, string lastName, string email, DateTime dateOfBirth, double? hourlyRate) : base(firstName, lastName, email, dateOfBirth, hourlyRate) // call base class constructor from employee
    {
    }

// functionalty only accessiblr to Manager class
    public void AttendManagementMeeting()
    {
        NumberOfHoursWorked += 10; 
        Console.WriteLine($"{FirstName} is attending a management meeting.");
    }
}
