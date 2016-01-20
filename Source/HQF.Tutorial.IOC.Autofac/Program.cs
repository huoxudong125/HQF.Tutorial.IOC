using System;
using Autofac;
using Autofac.Configuration;
using HQF.Tutorial.IOC.Common.Interface;

namespace HQF.Tutorial.IOC.Autofac
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Register other components and call Build() to create the container.

            var builder = new ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            var container = builder.Build();

            //Resolve the class
            var myclass = new MyClass(container.Resolve<InterfaceA>());
            myclass.CallPrint();

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