using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP2024Q3
{
    internal class Person
    {
        //public string Name { get; set; } = ""; 
        //public string? Name { get; set; } 
        public string Name { get; set; } = string.Empty;

    }
    internal class Employee : Person
    {
        public int Salary { get; set; }
    }

    internal class Admin : Employee
    {
        public string Department { get; set; } = string.Empty; 
    }
}
