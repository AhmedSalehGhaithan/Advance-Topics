using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators_enumrable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee() { Id = 1, Name = "Ahmed", Department = "number1", salary = 5412 };
            var employee2 = new Employee() { Id = 1, Name = "Ahmed", Department = "number1", salary = 5412 };

            Console.WriteLine(employee1.Equals(employee2));
            Console.WriteLine(employee2==employee1);
        }
    }
}
