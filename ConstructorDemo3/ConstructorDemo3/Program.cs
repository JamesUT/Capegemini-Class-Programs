using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(101,"Robert",300000.0);

            Console.WriteLine("Employee ID :" + emp.EmployeeID);
            Console.WriteLine("Employee Name :" + emp.EmployeeName);
            Console.WriteLine("Employee Salary :" + emp.Salary);

            Console.ReadKey();
        }
    }
}
