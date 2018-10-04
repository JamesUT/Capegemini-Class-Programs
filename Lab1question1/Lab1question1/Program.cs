using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1Question1Library;

namespace Lab1question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[10];
            Console.WriteLine("************************************Enter Employee Details************************************");
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i] = new Employee();
                Console.WriteLine("For Employee " + (i+1) + " =>");

                Console.Write("Employee ID :");
                emp[i].EmployeeID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Employee name :");
                emp[i].EmployeeName = Console.ReadLine();

            }
        }
    }
}
