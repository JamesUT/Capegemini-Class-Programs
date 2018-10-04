using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    class Employee
    {
        int salary;

        public int Salary
        {
            get { return salary; }
        }

        public Employee(int sal)
        {
            salary = sal;
        }

        public virtual int GiveBonus(int amount)
        {
            return salary + amount;
        }
    }
}
