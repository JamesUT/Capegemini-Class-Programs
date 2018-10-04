using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLibrary
{
    public interface IPrintable
    {
        void Print();
        void Show();

        int MyProp { get; set; }
    }
}
