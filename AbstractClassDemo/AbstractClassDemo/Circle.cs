using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle class Draw methord.");
        }
    }
}
