using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritenceDemo1
{
    class Manager : Employee
    {
        public Manager()
        {
            Console.WriteLine("Manager Class Default constructor");
        }
        public Manager(int id, string name, double sal,double comp)
        {
            Console.WriteLine("Employee Class Parametrized constructor");
        }
    }
}
