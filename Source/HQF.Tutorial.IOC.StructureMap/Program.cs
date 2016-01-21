using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using HQF.Tutorial.IOC.Common.Interface;
using StructureMap;
using StructureMap.Graph;

namespace HQF.Tutorial.IOC.StructureMap
{
    class Program
    {
        static void Main(string[] args)
        {
            //var container = new Container(x =>
            // {
            //     x.Scan(o =>
            //     {
            //         o.TheCallingAssembly();
            //         o.ExcludeNamespace("HQF.Tutorial.IOC.Common");
            //         o.AddAllTypesOf<InterfaceA>();
            //     });
            // });

            // foreach (var instance in container.Model.InstancesOf<InterfaceA>())
            // {
            //     Debug.WriteLine(instance.Name + " is " + instance.Name);

            //     Console.WriteLine(instance.Name,instance.PluginType);
            // }
           
            var container = new Container(
                x =>
                {
                    ;
                });
            var a = container.TryGetInstance<InterfaceA>();

            var myClass=new MyClass(a);
            myClass.CallPrint();
            

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
