using System;

namespace EmployeeManagement
{
    static void Main(string[] args)
    {
        Employee fullTimeEmployee = new FullTimeEmployee(123, "Karen", "HR", 50000, 213.59);
        Employee partTimeEmployee = new PartTimeEmployee(111, "Ethan", "Cashier", 21000, 14.23, 21);
        Employee contractor = new Contractor(333, "Carrie", "Pepsi Stocker", 30000, 12/31/2024);

        Console.WriteLine("Full Time Employee Details:");
        fullTimeEmployee.DisplayEmployeeDetails();
        Console.WriteLine($"Total Pay: {fullTimeEmployee.CalculatePay()}");

        Console.WriteLine("\nPart Time Employee Details:");
        partTimeEmployee.DisplayEmployeeDetails();
        Console.WriteLine($"Total Pay: {partTimeEmployee.CalculatePay()}");

        Console.WriteLine("\nContractor Details:");
        contractor.DisplayEmployeeDetails();
        Console.WriteLine($"Total Pay: {contractor.CalculatePay()}");
    }
    
    
}