using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape();    Cannot create object of abstract class

            Shape sc = new Circle();    //But we can take the reference of abstract class
            sc.Draw();
            sc.Show();

            Circle c = new Circle();
            c.Draw();
            c.Show();

            Shape ss = new Square();    //But we can take the reference of abstract class
            ss.Draw();
            ss.Show();

            Square s = new Square();
            s.Draw();
            s.Show();

            Console.ReadKey();
        }
    }
}
