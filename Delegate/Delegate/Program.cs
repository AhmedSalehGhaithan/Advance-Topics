using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee[]
            {
                new Employee {Id=1,Name="Ahmed",Gender = "M",TotalSalary =650000 },
                new Employee {Id=1,Name="Ali",Gender = "M",TotalSalary =4000 },
                new Employee {Id=1,Name="Mohamed",Gender = "M",TotalSalary =54000 },
                new Employee {Id=1,Name="Sara",Gender = "F",TotalSalary = 57000},
                new Employee {Id=1,Name="Samah",Gender = "F",TotalSalary =15000 },
                new Employee {Id=1,Name="Saleh",Gender = "M",TotalSalary =24000 },
                new Employee {Id=1,Name="Samy",Gender = "M",TotalSalary = 65000},
                new Employee {Id=1,Name="Alia",Gender = "F",TotalSalary =89000 }
            };

            var report = new Report();
            report.ProcessEmployee(employee, "Employee with salary  > $ 60000", (e) => e.TotalSalary > 60000);
            report.ProcessEmployee(employee, "Employee with salary between 30000  and 60000", (e)=> e.TotalSalary > 30000 && e.TotalSalary < 59999);
        }
    }
}
