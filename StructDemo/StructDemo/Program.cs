using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(2,5);
            p.X += 100;
            int px = p.X; // px=102

            Console.WriteLine("The value of px :" + px);

            Console.ReadKey();
        }
    }

    public struct Point
    {
        int x, y;
        public Point(int x,int y)
            {
            this.x = x;
            this.y = y;
            }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
