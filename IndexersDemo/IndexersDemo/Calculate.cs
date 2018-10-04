using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersDemo
{
    class Calculate
    {
        int [] arr;

        public  Calculate(int size)
        {
            arr = new int[size];
        }

        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }
    }
}
