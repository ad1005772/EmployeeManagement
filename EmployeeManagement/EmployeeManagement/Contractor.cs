using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Contractor
    {
        public class Contractor : Employee
        {
            public DateTime contractExpireDate { get; set; }

            public Contractor(int ID, string Name, string Department, decimal BaseSalary, DateTime ContractExpireDate) : base(ID, Name, Department, BaseSalary)
            {
                contractExpireDate = ContractExpireDate;
            }

            public override decimal CalculatePay()
            {
                return baseSalary;
            }

            public override void DisplayEmployeeDetails()
            {
                Console.WriteLine($"ID: {id}, Name: {name}, Department = {department}, Base Salary: {baseSalary}, Contract Expire Date: {contractExpireDate.ToShortDateString()}");
            }
        }
    }
}
