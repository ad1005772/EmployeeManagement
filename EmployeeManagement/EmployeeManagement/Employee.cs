using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeManagement
{
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public decimal baseSalary { get; set; }
        decimal hours = 2080;//2080 is average hours 40hr/wk employee works
        public Employee(int ID, string Name, string Department, decimal BaseSalary)
        {
            id = ID;
            name = Name;
            department = Department;
            baseSalary = BaseSalary;
        }

        public virtual decimal CalculatePay()
        {
            return baseSalary;
        }

        public virtual void DisplayEmployeeDetails()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Department = {department}, Base Salary: {baseSalary}");
        } 
    }
}
