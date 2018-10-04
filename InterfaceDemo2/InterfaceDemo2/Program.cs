using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    class Program 
    {
        //Explicit implementation of Interface

        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //emp.                                  we cannot use obect to refer the methords of interface when we explicitly implement interface

            IPrintable empPrint = new Employee();
            empPrint.Print();
            empPrint.Show();

            IDisplay empDisp = new Employee();
            empDisp.Display();
            empDisp.Show();

            Console.ReadKey();
        }
    }
}
