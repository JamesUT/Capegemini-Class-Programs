using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingMembersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Show();

            Manager mgr = new Manager();
            mgr.Show();

            Employee empmgr = new Manager();
            empmgr.Show();

            Console.ReadKey();
        }
    }
}
