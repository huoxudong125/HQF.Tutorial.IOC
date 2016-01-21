using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using HQF.Tutorial.IOC.Common.Interface;
using Ninject;
using Ninject.Modules;

namespace HQF.Tutorial.IOC.Ninject
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
       
        kernel.Load("yourXmlFileName.xml");
               bool ismodule = kernel.HasModule("myXmlConfigurationModule");//To Check The module 

        var a=kernel.Get<InterfaceA>();
            a.Print();

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
