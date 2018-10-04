using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritenceDemo1
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Employee Class Default constructor");
        }
        public Employee(int id,string name,double sal)
        {
            Console.WriteLine("Employee Class Parametrerised constructor");
        }
    }
}
