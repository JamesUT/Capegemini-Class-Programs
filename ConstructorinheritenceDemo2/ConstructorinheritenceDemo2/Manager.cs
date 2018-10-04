using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorinheritenceDemo2
{
    class Manager : Employee
    {
        public Manager()
        {
            Console.WriteLine("Manager Class Default constructor");
        }
        public Manager(int id, string name, double sal, double comp) : base (id ,name,sal)
        {
            Console.WriteLine("Employee Class Parametrized constructor");
        }
    }
}
