using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo1
{
    public interface IPrintable
    {
        //public void Show();       we cannot have access specifier in interfaces
        void Show();
        void Print();
    }
}
