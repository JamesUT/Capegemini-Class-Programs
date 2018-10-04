using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Question2ClassLibrary
{
    public class MathLib
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
        
        public double FAdd(double num1, double num2)
        {
            return num1 + num2;
        }

        public double FSubtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double FMultiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double FDivide(double num1, double num2)
        {
            return num1 / num2;
        }
        public double FModulus(double num1, double num2)
        {
            return num1 % num2;
        }
    }
}
