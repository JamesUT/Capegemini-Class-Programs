using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    delegate T Genericdelegate<T>(T val);

    class Program
    {
        public static int Addition(int val)
        {
            int sum = 0;
            for (int i = 0; i <= val; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static string reverse(string str)
        {
            string result = "";

            for (int i = (str.Length)-1; i >= 0 ; i--)
            {
                result = result + str[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            Genericdelegate<int> intDel = new Genericdelegate<int>(Addition);

            Console.WriteLine("Addition : " + intDel(10));

            Genericdelegate<string> stringDel = new Genericdelegate<string>(reverse);

            Console.WriteLine("Reverse : " + stringDel("abc"));

            Console.ReadKey();
        }
    }
}
