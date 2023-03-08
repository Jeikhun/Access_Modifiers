using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers_2.Models
{
    public class Department
    {   
        
        Employee[] employees= new Employee[0];
        Employee employee;
        public string Name { get; set; }
        public int SalaryLimit { get; set; } = 250;
        public int EmployeeLimit { get; set; } = 2;
        public void AddEmployee()
        {
            for (int i = 0; i <= EmployeeLimit; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Elave olunacag Isci adi: ");
                string name = Console.ReadLine();
                while (!char.IsUpper(name[0]) || name.Any(char.IsDigit) || name.Any(char.IsSymbol))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Duzgun ad daxil edin: ");
                    name = Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Elave olunacag Isci Soyadi: ");
                string surname = Console.ReadLine();
                while (!char.IsUpper(surname[0]) || surname.Any(char.IsDigit) || surname.Any(char.IsSymbol))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Duzgun soyad daxil edin: ");
                    surname = Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Elave olunacag Isci Maasi: ");
                int salary = int.Parse(Console.ReadLine());
                while (salary < SalaryLimit)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Minimal emekhaqqi 250azndir, Duzgun daxil edin: ");
                    salary = int.Parse(Console.ReadLine());
                }
                if (employees.Length < EmployeeLimit)
                {
                    employee = new Employee(name, surname, salary);
                    Array.Resize(ref employees, employees.Length + 1);
                    employees[employees.Length - 1] = employee;
                    
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Max ischi sayina chatmisiniz");
                }
            }
            
            

        }
        public void PrintEmployee()
        {
            foreach (var employee in employees)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Name: {employee.Name}   Surname: {employee.Surname}   Salary: {employee.Salary}");
            }
        }
    }
}
