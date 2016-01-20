using System;
using HQF.Tutorial.IOC.Common.Interface;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace HQF.Tutorial.IOC.Unity
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Load configuration from app.config.
            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration();

            //Resolve the class
            var myclass = container.Resolve<MyClass>();
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