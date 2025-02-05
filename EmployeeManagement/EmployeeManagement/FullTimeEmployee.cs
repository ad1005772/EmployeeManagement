using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class FullTimeEmployee
    {
        public class FullTimeEmployee : Employee
        {
            public decimal annualBonus { get; set; }
            public FullTimeEmployee(int ID, string Name, string Department, decimal BaseSalary, decimal AnnualBonus) : base(ID, Name, Department, BaseSalary)
            {
                annualBonus = AnnualBonus;
            }

            public override decimal CalculatePay()
            {
                return baseSalary + annualBonus;
            }
            public override void DisplayEmployeeDetails()
            {
                Console.WriteLine($"ID: {id}, Name: {name}, Department = {department}, Base Salary: {baseSalary}, Annual Bonus: {annualBonus}");
            }
        }
    }
}
