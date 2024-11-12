using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Subscriber
    {
        //target method (EVnet handler)
        public void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }
}
