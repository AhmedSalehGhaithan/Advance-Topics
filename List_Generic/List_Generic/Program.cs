using System;
using System.Collections.Generic;
namespace Generic_Collection
{
    class MainClass
    {
        static void Main(string[] args)
        {
            List<string> countryList = new List<string>();
            List<string> EmployeeList = new List<string>() { "Ahmed", "mohamed" };
            var employee = new List<string>();

            // add
            countryList.Add("USA");
            countryList.Add("YEMEN");
            countryList.Add("EYGPT");
            countryList.Add("CHINA");
            countryList.Add("KSA");

            //access by index
            Console.WriteLine($"First Element of list is :{countryList[0]}");
            Console.WriteLine($"Last Element of list is :{countryList[countryList.Count-1]}");
            Console.WriteLine("----------------------------------------------");
            // iterate throug list
            for (int i = 0;i < countryList.Count; i++)
            {
                Console.WriteLine(countryList[i]);
            }

            Console.WriteLine("----------------------------------------------");

            //insert itemin list
            countryList.Insert(2, "MOROQO");
            foreach(var country in countryList)
            {
                Console.WriteLine(country);
            }

            // remove element
            countryList.Remove("KSA");
            Console.WriteLine("----------------------------------------------");
            foreach (var country in countryList)
            {
                Console.WriteLine(country);
            }

            // copy the list
            Console.WriteLine("----------------------------------------------");
            string[]array = new string[countryList.Count];
            countryList.CopyTo(array, 0);
            foreach (var country in array)
            {
                Console.WriteLine(country);
            }
            //display short list
            Console.WriteLine("----------------------------------------------");
            var shortlist = countryList.GetRange(0, 3);
            foreach (var country in shortlist)
            {
                Console.WriteLine(country);
            }
            //sort item in list
            Console.WriteLine("----------------------------------------------");
            countryList.Sort();
            foreach (var country in countryList)
            {
                Console.WriteLine(country);
            }
            //reverse item in list
            Console.WriteLine("----------------------------------------------");
            countryList.Reverse();
            foreach (var country in countryList)
            {
                Console.WriteLine(country);
            }
        }
    }
}
