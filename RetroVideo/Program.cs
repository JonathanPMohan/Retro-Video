using System;
using System.Collections.Generic;

namespace RetroVideo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Retro Video!");
        }

        public class Company
        {
            /*
                Some readonly properties
            */
            public string CompanyName { get; }
            public DateTime CreatedOn { get; }

            // Create a property for holding a list of current employees

            public List<EmployeeInfo> employees { get; set; }

            // Create a method that allows external code to add an employee

            public void AddEmployee(EmployeeInfo newEmployee)
            {
                employees.Add(newEmployee);
            }

            // Create a method that allows external code to remove an employee

            public void RemoveEmployee(EmployeeInfo exEmployee)
            {
                employees.Remove(exEmployee);
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

            }
        }
    }
}
