using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethordProgram
{
    class Program
    {
        public void Swap<T>(ref T num1,ref T num2)
        {
            T temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int num1 = 1;
            int num2 = 2;
            p.Swap<int>(ref num1,ref num2);

            Console.WriteLine("Val1 =" + num1 + " Val2 =" + num2);

            string str1 = "Utkarsh";
            string str2 = "Upadhyay";

            p.Swap<string>(ref str1, ref str2);

            Console.WriteLine("Val1 =" + str1 + " Val2 =" + str2);

            Console.ReadKey();
        }
    }
}
