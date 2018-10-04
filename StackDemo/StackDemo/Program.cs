using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stackObject = new Stack();
            stackObject.Push("Utkarsh");
            stackObject.Push("Upadhyay");
            stackObject.Push("Nothng");
            while (stackObject.Count>0)
            {
                Console.WriteLine(stackObject.Pop());
            }
            Console.ReadKey();
        }
    }
}
