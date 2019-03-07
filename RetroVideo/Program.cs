using System;
using System.Collections.Generic;

namespace RetroVideo
{
    class Program
    {

        public class Company
        {

            /*
            Some readonly properties
            */

            public string CompanyName { get; }
            public DateTime CreatedOn { get; }

            // Create a property for holding a list of current employees

            public List<EmployeeInfo> Employees { get; set; }

            // Create a method that allows external code to add an employee

            public void AddEmployee(EmployeeInfo newEmployee)
            {
                Employees.Add(newEmployee);
            }

            // Create a method that allows external code to remove an employee

            public void RemoveEmployee(EmployeeInfo exEmployee)
            {
                Employees.Remove(exEmployee);
            }

            public void listEmployees(List<EmployeeInfo> employees)
            {
                foreach (EmployeeInfo employee in employees)
                    Console.WriteLine(employee.FirstName);
            }

            /*
                Create a constructor method that accepts two arguments:
                    1. The name of the company
                    2. The date it was created
                The constructor will set the value of the public properties
            */
            public Company(string companyName, DateTime createdOn)
            {
                CompanyName = companyName;
                CreatedOn = createdOn;
                Employees = new List<EmployeeInfo>();

            }

            public void ListEmployees(List<EmployeeInfo> employees)
            {
                foreach (EmployeeInfo employee in employees)
                    Console.WriteLine(employee.FirstName, employee.LastName);
            }

            static void Main(string[] args)
            {
                Company RexBot = new Company("Rex Bot", DateTime.Now);

                EmployeeInfo rex = new EmployeeInfo("Davis", "Rex", "Owner", DateTime.Now);
                EmployeeInfo bot = new EmployeeInfo("Bot", "Ro", "Computer", DateTime.Now);
                EmployeeInfo gunner = new EmployeeInfo("Nelson", "Gunner", "Manager", DateTime.Now);

                RexBot.AddEmployee(rex);
                RexBot.AddEmployee(bot);
                RexBot.AddEmployee(gunner);

                Console.WriteLine("Welcome To Rex Bot's Employee Vault");
                Console.WriteLine("Hit Any Key To See List.");
                Console.ReadKey();

                RexBot.listEmployees(RexBot.Employees);
                Console.WriteLine("Hit Any Key To Exit.");
                Console.ReadKey();
            }
        }
    }
}