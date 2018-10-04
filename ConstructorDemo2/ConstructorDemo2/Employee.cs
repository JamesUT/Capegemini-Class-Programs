using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo2
{
    public class Employee
    {
        int id;
        string name;
        double salary;
        static string company;

        static Employee()
        {
            company = "Capgemini";
        }

        public Employee()
        {
            id = 0;
            name = "";
            salary = 0.0;
            //company = "";
        }

        public Employee(int eid , string ename, double sal)
        {
            id = eid;
            name = ename;
            salary = sal;
            //company = comp;
        }
    }
}
