using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionDemo
{
    class Program
    {
        public delegate void LambdaDel();
        public delegate void LambdaDelParam(int val1, int val2);
        public delegate string LambdaDelReturn(string val1,string val2);
        static void Main(string[] args)
        {
            LambdaDel anDel = delegate
            {
                Console.WriteLine("Annonymous methord Called.");
            };
            anDel();

            LambdaDel lDel = () => Console.WriteLine("lambda Expression Called.");
            lDel();

            LambdaDelParam anParam = delegate (int num1,int num2)
            {
                Console.WriteLine("Output using Add Methord {0} + {1} => {2}", num1, num2, (num1 + num2));
            };
            anParam(45,12);

            LambdaDelParam lParam = (num1,num2) => Console.WriteLine("Output using Add Methord {0} + {1} => {2}", num1, num2, (num1 + num2));
            lParam(45,12);

            //LambdaDelReturn lReturn = (string str1, string str2) => 
            //{
            //    return str1 + " " + str2;
            //};
            LambdaDelReturn lReturn = (string str1, string str2) => str1 + " " + str2;
            string result = lReturn("Utkarsh", "Upadhyay");
            Console.WriteLine("The result of Lambda Expression is:" + result);

            Console.ReadKey();
        }
    }
}
