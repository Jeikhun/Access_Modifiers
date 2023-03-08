using Access_Modifiers_2.Models;
using System;

namespace Access_Modifiers_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Department department = new Department();
            department.AddEmployee();
            department.PrintEmployee();
            Console.ReadKey();
            
        }
    }
}
