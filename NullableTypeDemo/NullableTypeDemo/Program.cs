using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = null;
            //Nullable<int> num = null;
            int? num = null;

            if (num.HasValue)
                Console.WriteLine("Number is :" + num.Value);
            else
                Console.WriteLine("Number is NULL.");
            Console.ReadKey();
        }
    }
}
