using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeManagement
{
    internal class EmployeeClass
    {
        public int id { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public decimal baseSalary { get; set; }
        public Employee(int ID, string Name, string Department, decimal BaseSalary)
        {
            id = ID;
            name = Name;
            department = Department;
            baseSalary = BaseSalary;
        }

        public void CalculatePay()
        {
            decimal pay = baseSalary * 2080;//number of hours for 40hr/week employee in a year 
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Department = {department}, Base Salary: {baseSalary}");
        } 
    }
}
