using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritenceDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();

            Manager m1 = new Manager(101,"robert",30000.0,30000);

            Console.ReadKey();

        }
    }
}
