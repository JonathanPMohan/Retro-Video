using System;
using System.Collections.Generic;

namespace RetroVideo
{
    class Program
    {

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