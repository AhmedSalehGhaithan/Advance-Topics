using System;
using System.Collections.Generic;

namespace DelegateWithMohamedAlmohamdy
{
    internal class Program
    {
        delegate bool ShouldCalculateDelegate(Employee employee);

        public class Employee
        {
            public string name { get; set; }
            public int BaseSalary { get; set; }
            public int Deduction { get; set; }
            public int Bonus { get; set; }
        }

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Random random = new Random(); // Create a single Random instance

            for (int i = 1; i <= 100; i++)
            {
                employees.Add(new Employee()
                {
                    name = $"Employee {i}",
                    BaseSalary = random.Next(100000, 500000),
                    Deduction = random.Next(0, 5000),
                    Bonus = random.Next(0, 10000)
                });
            }

            CalculateSalaries(employees, e => e.BaseSalary > 400000);
        }

        private static void CalculateSalaries(List<Employee> employees, ShouldCalculateDelegate predicate)
        {
            foreach (Employee employee in employees)
            {
                if (predicate(employee))
                {
                    var salary = employee.BaseSalary + employee.Bonus - employee.Deduction;
                    Console.WriteLine($"Salary for {employee.name} with base salary {employee.BaseSalary}: {salary}");
                }
            }
        }
    }
}
