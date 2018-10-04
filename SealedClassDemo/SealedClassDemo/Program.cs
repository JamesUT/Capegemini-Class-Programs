using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassDemo
{
    public sealed class MyClass
    { }
    //public class Calculate : MyClass                 cannot make a class Parent once you make it sealed Class.
    //{ }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
