using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersDemo
{
    class Program
    {
        public void Swap(int num1,int num2)
        {
            int t = num1;
            num1 = num2;
            num2 = t;
        }

        public void SwapByRef(ref int num1, ref int num2)
        {
            int t = num1;
            num1 = num2;
            num2 = t;
        }

        public void CircleFun(int radius,out double area, out double circum)
        {
            area = Math.PI * radius * radius;
            circum = 2 * Math.PI * radius;
            //return circum;    We cannot pass two numbers using return
        }

        public int Add(params int[] arr)
        {
            //params should be the last parameter in A Methord.
            int sum = 0;
            for(int i = 0; i < arr.Length;i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            int num1, num2;

            Console.Write("Enter First Number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n****************************Pass by Value****************************");
            // When we want our parameter should only require input, no out should be given.

            Console.WriteLine("Before Swapping");
            Console.WriteLine("Number 1 :" + num1);
            Console.WriteLine("Number 2 :" + num2);

            p.Swap(num1,num2);                        // We can use p.Swap(10,20);

            Console.WriteLine("\n After Swapping");
            Console.WriteLine("Number 1 :" + num1);
            Console.WriteLine("Number 2 :" + num2);

            Console.WriteLine("\n\n****************************Pass by Reference****************************");
            // Whne we want our parameter should require both input and out, and output shold be reflected back.

            Console.WriteLine("Before Swapping");
            Console.WriteLine("Number 1 :" + num1);
            Console.WriteLine("Number 2 :" + num2);

            p.SwapByRef(ref num1, ref num2);            //p.SwapByRef(ref 10, ref 20);   //Also the Variable must be initialized before being send.

            Console.WriteLine("\n After Swapping");
            Console.WriteLine("Number 1 :" + num1);
            Console.WriteLine("Number 2 :" + num2);

            Console.WriteLine("\n\n****************************Pass by Output****************************");
            int radius;
            double area, circum;

            Console.Write("Enter Radius :");
            radius = Convert.ToInt32(Console.ReadLine());

            p.CircleFun(radius, out area, out circum);

            Console.WriteLine("Area :" + area);
            Console.WriteLine("Circumference :"+ circum);

            Console.WriteLine("\n\n****************************Pass by Output****************************");
            Console.WriteLine("Add(20,30 :)" + p.Add(20, 30));
            Console.WriteLine("Add(20,30,40 :)" + p.Add(20, 30,40));
            Console.WriteLine("Add(20,30,40,50,60 :)" + p.Add(20, 30,40,50,60));

            Console.ReadKey();
        }
    }
}
