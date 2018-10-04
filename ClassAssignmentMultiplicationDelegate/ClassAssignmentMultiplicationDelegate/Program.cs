using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignmentMultiplicationDelegate
{
    public delegate void delegateExample(int val1, int val2);
    public delegate void AnnonymousDel(int val1,int val2);
    public delegate void LambdaDel(int val1, int val2);

    class Program
    {
        public static void mul(int num1,int num2)
        {
            Console.WriteLine("The result using Methord Delegate is : " +num1 * num2);
        }

        static void Main(string[] args)
        {
            Console.Write("*****************************************Multiplication of two number**************************************");
            Console.Write("Enter first number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            delegateExample del = new delegateExample(mul);
            del(num1,num2);

            AnnonymousDel del2 = delegate (int val1, int val2)
            {
                Console.WriteLine("Output using Annonymous Methord : "+ (val1 * val2));
            };
            del2(num1, num2);

            LambdaDel lDel = (int val1, int val2) =>
            {
                Console.WriteLine("Output using Lambda expression is :" + val1*val2);
            };
            lDel(num1,num2);

            Console.ReadKey();
        }
    }
}
