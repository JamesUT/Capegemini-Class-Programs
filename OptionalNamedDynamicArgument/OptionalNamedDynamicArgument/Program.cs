using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalNamedDynamicArgument
{
    class Program
    {
        public static void Add(int num1, int num2=65, int num3=90)
        {
            Console.WriteLine("{0} + {1} + {2} => {3}", num1, num2, num3, (num1 + num2 + num3));
        }

        static void Main(string[] args)
        {
            Add(100);
            Add(100, 200);
            Add(100, 200, 300);

            Add(num2: 100, num1: 300, num3: 200);

            
            object obj = "Capgemini";

            var str = "Capgemini";
            str.ToUpper();

            dynamic d = "Capgemini";
            d.tosjdhfjhfjdfjdf();

            Console.ReadKey();
        }
    }
}
