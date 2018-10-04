using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo1
{
    public class Employee : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Employee Class implemented Print methord of IPrintable.");
        }

        public void Show()
        {
            Console.WriteLine("Employee Class implemented Show methord of IPrintable.");
        }
    }
}
