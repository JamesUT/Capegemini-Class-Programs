using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] cities = new char[5][];
            for (int i = 0; i < cities.GetLength(0); i++)
            {
                int size;
                Console.Write("Enter the number of charecter for city " + (i+1) + " : ");
                size = Convert.ToInt32(Console.ReadLine());

                cities[i] = new char[size];
                Console.WriteLine("Enter the city characters : ");
                for (int j = 0; j < cities[i].Length; j++)
                {
                    cities[i][j] = Convert.ToChar(Console.ReadLine());
                }
            }
            Console.WriteLine("Cities are :");
            for (int i = 0; i < cities.GetLength(0); i++)
            {
                for (int j = 0; j < cities[i].Length; j++)
                {
                    Console.Write(cities[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
