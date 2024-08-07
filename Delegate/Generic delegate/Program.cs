using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_delegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> list = new int[] { 17, 10, 5, 2, 9, 6, 2, 4, 7, 89, 3, 6 };

            IEnumerable<double> listD = new double[] { 17.5, 10.0, 5.0, 2.2, 9.5, 6.6, 2.5, 4.0 };
 
            PrintNumber(list, (n) => n < 7, () => Console.WriteLine("integer Number less than 7 :"));

            PrintNumber(listD, (n) => n < 7, () => Console.WriteLine("double Number less than 7 :"));

            PrintNumber(list, (n) => n >= 7, () => Console.WriteLine("integer Number bigger than 7 :"));

            PrintNumber(list, (n) => n % 2 == 0, () => Console.WriteLine("Even numbers :"));

            PrintNumber(list, (n) => n % 2 != 0, () => Console.WriteLine("Odd numbers : "));
        }

        static void PrintNumber<T>(IEnumerable<T> number,Func<T,bool> filtr,Action action)
        {
            action();
            foreach (var i in number)
            {
                if (filtr(i))
                {
                    Console.Write($"{i}  ");
                }
            }
            Console.WriteLine();
        }
    }
}
