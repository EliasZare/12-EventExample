using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    //Public Delegate
    public delegate void MyDelegateType(int a, int b);
    public class Publisher
    {
        //private Delegate
        private MyDelegateType MyDelegate;
        public event MyDelegateType MyEvent
        {
            add => MyDelegate += value;

            remove => MyDelegate -= value;
        }
        public void RiseEvent(int a, int b)
        {
            this.MyDelegate(a, b);
        }


        //Auto-Implemented Events

        public event MyDelegateType MyAutoImplementedEvent;
        public void RiseAutoImplementedEvent(int a , int b)
        {
            this.MyAutoImplementedEvent(a, b);
        }
    }
}
