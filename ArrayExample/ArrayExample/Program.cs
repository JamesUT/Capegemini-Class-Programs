using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("For Single dimension Array:");
            Console.WriteLine("Enter the number one by one:");
            for(int i=0;i<a.Length;i++)
            {
                //a[i] = int.Parse(Console.ReadLine());
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values entered are :");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(i + " == " + a[i]);
            }
            Console.WriteLine("The SORTED array is :");
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(i + " == " + a[i]);
            }
            Array.Reverse(a);
            Console.WriteLine("The REVERSE array is :");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(i + " == " + a[i]);
            }
            Console.ReadKey();
        }
    }
}
