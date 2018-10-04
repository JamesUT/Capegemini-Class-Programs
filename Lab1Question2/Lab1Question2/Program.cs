using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1Question2ClassLibrary;

namespace Lab1Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathLib obj = new MathLib();
            Console.WriteLine("****************************************************Math Application****************************************************");
            Console.WriteLine("If you want to enter numbers in Integer Press 1 or Press 2 for double :");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == 1)
            {
                Console.WriteLine("Enter Two Integer Numbers :");
                Console.Write("Number 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number 2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Press Corrosponding Numbers : \n Addition => 1 \t Substraction => 2 \t Multiplication => 3 \t Division => 4 \t Modulus Operation => 5 \t Your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int sum = obj.Add(num1, num2);
                        Console.WriteLine("Addition of two numbers is : " + sum);
                        break;
                    case 2:
                        int sub = obj.Subtract(num1, num2);
                        Console.WriteLine("Subtraction of two numbers is : " + sub);
                        break;
                    case 3:
                        int mul = obj.Multiply(num1, num2);
                        Console.WriteLine("Division of two numbers is : " + mul);
                        break;
                    case 4:
                        int div = obj.Divide(num1, num2);
                        Console.WriteLine("Multiplication of two numbers is : " + div);
                        break;
                    case 5:
                        int mod = obj.Modulus(num1, num2);
                        Console.WriteLine("Modulus of two numbers is : " + mod);
                        break;
                    default:
                        Console.WriteLine("The Input is wrong.");
                        break;
                }
            }
            else if (c == 2)
            {
                Console.WriteLine("Enter Two Floating Numbers :");
                Console.Write("Number 1: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Number 2: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Press Corrosponding Numbers : \n Addition => 1 \t Substraction => 2 \t Multiplication => 3 \t Division => 4 \t Modulus Operation => 5 \t Your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        double sum = obj.FAdd(num1, num2);
                        Console.WriteLine("Addition of two numbers is : " + sum);
                        break;
                    case 2:
                        double sub = obj.FSubtract(num1, num2);
                        Console.WriteLine("Substraction of two numbers is : " + sub);
                        break;
                    case 3:
                        double mul = obj.FMultiply(num1, num2);
                        Console.WriteLine("Multiplication of two numbers is : " + mul);
                        break;
                    case 4:
                        double div = obj.FDivide(num1, num2);
                        Console.WriteLine("Division of two numbers is : " + div);
                        break;
                    case 5:
                        double mod = obj.FModulus(num1, num2);
                        Console.WriteLine("Modulus of two numbers is : " + mod);
                        break;
                    default:
                        Console.WriteLine("The Input is wrong.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("The Entered input is wrong.");
            }
            Console.ReadKey();
        }
    }
}
