using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstraintsDemo
{
    public class MyGenClass<T> where T : class                          // on using struct we will only be allowed to add value type data's
    {

    }

    public struct Student
    {
        public int RollNo { get; set; }
        public string StudName { get; set; }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string EmpName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            MyGenClass<int> objint = new MyGenClass<int>();
            MyGenClass<Student> objStud = new MyGenClass<Student>();
            MyGenClass<char> objChar = new MyGenClass<char>();
            MyGenClass<byte> objByte = new MyGenClass<byte>();

            //reference type
            MyGenClass<object> obj = new MyGenClass<object>();
            MyGenClass<string> objString = new MyGenClass<string>();
            MyGenClass<Employee> objEmployee = new MyGenClass<Employee>();
        }
    }
}
