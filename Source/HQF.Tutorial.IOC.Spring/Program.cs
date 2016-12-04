using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HQF.Tutorial.IOC.Common.Interface;

namespace HQF.Tutorial.IOC.Spring
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.Read();
        }

    }

    public class MyClass
    {
        public InterfaceA ComponentA { get; set; }

        //Dependencies Inject,using constructor.
        public MyClass(InterfaceA a)
        {
            ComponentA = a;
        }

        public void CallPrint()
        {
            if (ComponentA != null)
            {
                ComponentA.Print();
            }
            else
            {
                Console.WriteLine("The ComponentA is null!");
            }
        }
    }


}
