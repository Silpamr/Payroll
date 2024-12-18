using Payroll_system.Models;
using System;

namespace Payroll_system
{
    public class Payroll
    {
        private PayrollSystem payroll;

        public Payroll()
        {
            payroll = new PayrollSystem();
        }

        public void Run()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Payroll System ---");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Display Employees");
                Console.WriteLine("3. Calculate Total Payroll");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;

                    case 2:
                        payroll.DisplayEmployees();
                        break;

                    case 3:
                        Console.WriteLine($"Total Payroll: {payroll.CalculateTotalPayroll():C}");
                        break;

                    case 4:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void AddEmployee()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Role (Manager/Developer/Intern): ");
            string role = Console.ReadLine();

            BaseEmployee employee = null;

            switch (role)
            {
                case "Manager":
                    employee = new Manager
                    {
                        Id = new Random().Next(1000, 9999),
                        Name = name,
                        BasicPay = 5000,
                        Allowances = 1000,
                        Bonus = 2000
                    };
                    break;

                case "Developer":
                    employee = new Developer
                    {
                        Id = new Random().Next(1000, 9999),
                        Name = name,
                        BasicPay = 4000,
                        Allowances = 800
                    };
                    break;

                case "Intern":
                    employee = new Intern
                    {
                        Id = new Random().Next(1000, 9999),
                        Name = name,
                        BasicPay = 2000,
                        Allowances = 200,
                        Deduction = 100
                    };
                    break;

                default:
                    Console.WriteLine("Invalid role entered.");
                    break;
            }
        }
    }
}
