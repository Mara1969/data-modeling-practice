using BethanysPieShopHRM.HR;

namespace BethanysPieShopHRM.Tests
{

    public class EmployeeTests
    {
        [Fact] 
        public void PerformWork_Adds_NumberOfHours()
        {
            //Arrange
            Employee employee1 = new Employee("Bethany", "Smith", "bethany.smith@hotmail.com", new DateTime(1990, 5, 23), 25);
            int numberOfHours = 3;

            //Act
            employee1.PerformWork(numberOfHours);

            //Assert 
            Assert.Equal(numberOfHours, employee1.NumberOfHoursWorked);
        }

        [Fact] 
        public void PerformWork_Adds_DefaultNumberOfHours_IfNoValueSpecified()
        {
            //Arrange
            Employee employee1 = new Employee("Bethany", "Smith", "bethany.smith@hotmail.com", new DateTime(1990, 5, 23), 25);

            //Act
            employee1.PerformWork();

            //Assert 
            Assert.Equal(1, employee1.NumberOfHoursWorked); // default is 1 hour, the minimalHoursWorkedUnit defined in employee class
        }
    }
}
