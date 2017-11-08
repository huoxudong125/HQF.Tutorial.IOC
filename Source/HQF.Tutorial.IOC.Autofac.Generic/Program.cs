using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQF.Tutorial.IOC.Autofac.Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<OrderPaidEventHandler>().As<IEventHander<OrderPaidEvent>>();

            var container=  builder.Build();



            //var ope= container.Resolve<IEventHander<OrderPaidEvent>>();

            // Console.WriteLine(ope);
            //var e=(IEvent)new OrderPaidEvent();
            var e = new OrderPaidEvent();



            GetEvent(container,e);

            Console.Read();


        }

        public static void GetEvent<T>(IContainer container, T t)  where T:IEvent {


            var ope = container.Resolve<IEventHander<T>>();

            Console.WriteLine(ope);

        }
    }
}
