using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Employee Default constructor called");
        }
        
        public Employee(int id)
        {
            Console.WriteLine("Employee Parameterized Constructor called with 1 parameter");
        }
        
        public Employee(int id,string name)
        {
            Console.WriteLine("Employee Parameterized Constructor called with 2 parameter");
        }

        static Employee()      //Public private and protected cannot be declared. Like == "public static  Employee()"
        {
            // Debugger also cannot track Static Constructor
            Console.WriteLine("Employee Static Constructor called.");
        }
    }
}
