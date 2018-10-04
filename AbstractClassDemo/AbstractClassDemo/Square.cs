using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Square class Draw methord.");
        }
        public override void Show()
        {
            Console.WriteLine("Square class Show methord.");
        }
    }
}
