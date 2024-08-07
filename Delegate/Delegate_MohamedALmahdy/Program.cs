using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_MohamedALmahdy
{
    public class Delegate_MohamedALmahdy
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
            List<Employee> employee = new ();
            for(int i=1;i<=100;i++)
            {
                employee.Add(new Employee()
                {
                    name = $"Employee {i}",
                    BaseSalary = Random.Shared.Next(10000, 50000),
                    Deduction = Random.Shared.Next(0, 5000),
                    Bonus = Random.Shared.Next(0, 10000)
                }) ; 
            }

            CalculateSalaries(employee, e => e.BaseSalary > 2000);
            
        }
        private static void CalculateSalaries(List<Employee> employees, ShouldCalculateDelegate predicate)
        {
            foreach(Employee employee in employees)
            {
                if (predicate(employee))
                {
                    var salary = employee.BaseSalary + employee.Bonus - employee.Deduction;
                    Console.WriteLine($"Salary for employee {employee.name} with base salary {employee.BaseSalary}");
                }
            }
        }
    }
}
