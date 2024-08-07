using System;

namespace Delegate
{
    public class Report
    {
        public delegate bool IsIllageble(Employee e);

        public void ProcessEmployee(Employee[]employees, string title, IsIllageble isIllageble)
        {
            Console.WriteLine($"{title}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (Employee Emp in employees)
            {
                if (isIllageble(Emp))
                {
                    Console.WriteLine($"{Emp.Id} | {Emp.Name} | {Emp.Gender} | {Emp.TotalSalary}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
