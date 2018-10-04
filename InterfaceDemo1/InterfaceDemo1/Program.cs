using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPrintable i = new IPrintable();   // cannot create instance of Interface
            Employee emp = new Employee();
            emp.Print();
            emp.Show();

            Console.ReadKey();
        }
    }
}
