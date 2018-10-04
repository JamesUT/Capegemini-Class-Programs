using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate(10);

            cal[3] = 56;
            cal[9] = 931764;
            cal[0] = 104;

            Console.WriteLine("Array Elements :");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(cal[i]);
            }
            Console.ReadKey();
        }
    }
}
