using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssymetricAccessorPropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmployeeID = 101;
            emp.EmployeeName = "Robert";
            emp.EmployeeSal = 100000;

            Console.WriteLine("Employee ID :" + emp.EmployeeID);
            Console.WriteLine("Employee Name :" + emp.EmployeeName);
            Console.WriteLine("Employee Salary :" + emp.EmployeeSal);
        }
    }
}
