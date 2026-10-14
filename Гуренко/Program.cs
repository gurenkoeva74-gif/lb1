using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Гуренко
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();


            employee.FullName = "Иванов";
            employee.Salary = 63500;


            employee.Show();


            float annualSalary = employee.CalculateAnnualSalary();
            Console.WriteLine($"Годовая зарплата: {annualSalary}");

            Console.ReadKey();
        }
    }

    class Employee
    {

        public string FullName;
        public float Salary;

        public void Show()
        {
            Console.WriteLine($"ФИО: {FullName}");
            Console.WriteLine($"Зарплата: {Salary}");
        }


        public float CalculateAnnualSalary()
        {
            return Salary * 12;
        }
    }

}
