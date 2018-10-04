using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check size for datatypes
            Console.WriteLine("Size of integer :" + sizeof(int));
            Console.WriteLine("Size of float :" + sizeof(float));
            Console.WriteLine("Size of double :" + sizeof(double));
            Console.WriteLine("Size of byte :" + sizeof(byte));
            Console.WriteLine("Size of long :" + sizeof(long));
            Console.WriteLine("Size of short :" + sizeof(short));
            Console.WriteLine("Size of boolean :" + sizeof(bool));
            Console.WriteLine("Size of char :" + sizeof(char));
            Console.WriteLine("Size of decimal :" + sizeof(decimal));
            Console.WriteLine("Size of uint :" + sizeof(uint));
            Console.WriteLine("Size of ulong :" + sizeof(ulong));
            Console.WriteLine("Size of ushort :" + sizeof(ushort));
            Console.WriteLine("Size of sbyte :" + sizeof(sbyte));
            //Console.WriteLine("Size of integer :" + sizeof(String));         //Not possible because they are user-defined types


            //Find Min and max values
            Console.WriteLine("Max limit of Int :" + int.MaxValue);
            Console.WriteLine("Min limit of Int :" + int.MinValue);
            Console.WriteLine("Max limit of decimal :" + decimal.MaxValue);
            Console.WriteLine("Min limit of decimal :" + decimal.MinValue);
            Console.WriteLine("Max limit of short :" + short.MaxValue);
            Console.WriteLine("Min limit of short :" + short.MinValue);
            Console.WriteLine("Max limit of long :" + long.MaxValue);
            Console.WriteLine("Min limit of long :" + long.MinValue);
            Console.WriteLine("Max limit of byte :" + byte.MaxValue);
            Console.WriteLine("Min limit of byte :" + byte.MinValue);
            Console.WriteLine("Max limit of uint :" + uint.MaxValue);
            Console.WriteLine("Min limit of uint :" + uint.MinValue);
            //Console.WriteLine("Max limit of Boolean :" + bool.MaxValue);     Not possible Because boolean doesnot cointain max or min values
            //Console.WriteLine("Min limit of Boolean :" + bool.MinValue);

            Console.WriteLine("type of int" + typeof(int) ); //CTS type of that particuler data

            //int num = 123;
            //Console.WriteLine("type of int" + num.GetType());

            int num = 123;
            object obj = num;
            int another = (int) obj;
            Console.WriteLine("the value in num is :" +num + "and in obj :" + obj + "and in another is:"+ another);m
            Console.ReadKey();
        }
    }
}
