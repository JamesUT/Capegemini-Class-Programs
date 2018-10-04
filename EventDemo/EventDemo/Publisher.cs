using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public delegate void EventHandlerDelegate();
    class Publisher
    {
        public event EventHandlerDelegate MyClickEvent;
        
        public void Notification()
        {
            if (MyClickEvent != null)
                MyClickEvent();
        }

    }
}
