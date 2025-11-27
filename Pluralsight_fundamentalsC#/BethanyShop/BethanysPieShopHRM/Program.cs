using BethanysPieShopHRM;

Console.WriteLine("Creating an employee!");
Console.WriteLine("------------------\n");

Employee employee1 = new("Bethany", "Smith", "bethany.smith@hotmail.com", new DateTime(1990, 5, 23), 25);
employee1.DisplayEmployeeDetails();
employee1.hourlyRate = 10;
employee1.PerformWork(8);
double employee1Wage = employee1.ReceiveWage(true);

Console.WriteLine("Creating an employee!");
Console.WriteLine("------------------\n");

Employee employee2 = new("John", "Doe", "john.doe@hotmail,com", new DateTime(1985, 3, 15), 30);
employee2.DisplayEmployeeDetails();
employee2.PerformWork(4);
double employee2Wage = employee2.ReceiveWage(false);    
