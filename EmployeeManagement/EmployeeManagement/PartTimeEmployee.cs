using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class PartTimeEmployee
    {
        public class PartTimeEmployee : Employee
        {
            public decimal hourlyRate { get; set; }
            public int hoursWorked {  get; set; }

            public PartTimeEmployee(int ID, string Name, string Department, decimal BaseSalary, decimal HourlyRate, int HoursWorked) : base(ID, Name, Department, BaseSalary)
            {
                hourlyRate = HourlyRate;
                hoursWorked = HoursWorked;
            }
            public override decimal CalculatePay()
            {
                return hourlyRate * hoursWorked;
            }

            public override void DisplayEmployeeDetails()
            {
                Console.WriteLine($"ID: {id}, Name: {name}, Department = {department}, Base Salary: {baseSalary}, Hourly Rate: {hourlyRate}, Hours Worked: {hoursWorked}");
            }
        }
}
