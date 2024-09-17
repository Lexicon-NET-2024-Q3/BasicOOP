using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP2024Q3
{

    internal interface IPerson
    {
        string Name { get; set; }
        void Do(); 
    }
    internal class Person : IPerson
    {
        //public string Name { get; set; } = ""; 
        //public string? Name { get; set; } 

        public string Name { get; set; } = string.Empty;

        public void Do()
        {
            Console.WriteLine("Person do");
        }
    }
    internal class Employee : Person
    {
        public int Salary { get; set; }

        //public void Do()
        //{
        //    Console.WriteLine("Employee do");
        //}
    }

    internal class Admin : Employee
    {
        public string Department { get; set; } = string.Empty; 
    }
}
