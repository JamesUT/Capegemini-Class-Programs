using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingMembersDemo
{
    public class Manager : Employee
    {
        public new void Show()
        {
            Console.WriteLine("Manager Class Show Methord");
        }
    }
}
