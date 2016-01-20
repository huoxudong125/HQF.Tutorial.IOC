using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQF.Tutorial.IOC.Common.Interface;

namespace HQF.Tutorial.IOC.Common.Implement
{
    public class ImplementA:InterfaceA
    {
        public void Print()
        {
            Console.WriteLine("This is the Implement A,Which implement the interface InterfaceA");
        }
    }
}
