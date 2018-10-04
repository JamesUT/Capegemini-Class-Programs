using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Employee emp1 = new Employee(101);

            Employee emp2 = new Employee(101,"Robert");

            Console.ReadKey();
        }
    }
}
