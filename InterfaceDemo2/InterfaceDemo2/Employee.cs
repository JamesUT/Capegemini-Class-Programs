using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    public class Employee : IPrintable, IDisplay
    {
        //public void Print()
        //{
        //    Console.WriteLine("Employee Class implemented Print methord of IPrintable.");
        //}

        //public void Show()
        //{
        //    Console.WriteLine("Employee Class implemented Show methord of IPrintable.");
        //}

        ////public void Show()                                                         //Two methord with same name
        //{
        //    Console.WriteLine("Employee Class implemented Show methord of IDISPLAY.");
        //}


        // So we need to Explicitly display the interfaces

        void IPrintable.Print()                     //Public keyword shold not be given
        {
            Console.WriteLine("Employee Class implemented Print methord of IPrintable.");
        }

        void IPrintable.Show()
        {
            Console.WriteLine("Employee Class implemented Show methord of IPrintable.");
        }

        void IDisplay.Display()
        {
            Console.WriteLine("Employee Class implemented Display methord of IDisplay.");
        }

        void IDisplay.Show()
        {
            Console.WriteLine("Employee Class implemented Show methord of IDisplay.");
        }

    }
}
