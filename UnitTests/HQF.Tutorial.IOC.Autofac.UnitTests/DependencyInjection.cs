using System.Runtime.Remoting.Contexts;
using Autofac;
using Autofac.Extras.DynamicProxy;
using HQF.Tutorial.IOC.AOP.Autofac;
using HQF.Tutorial.IOC.Common.Implement;
using HQF.Tutorial.IOC.Common.Interface;

namespace HQF.Tutorial.IOC.Autofac.UnitTests
{
    public class DependencyInjection
    {
        public static IContainer Register()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<Context>().AsSelf();

            containerBuilder.RegisterType<ItemService>().As<IItemService>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TransactionAspect))
                .InterceptedBy(typeof(ChangeArgumentsAspect));

            containerBuilder.RegisterType<TransactionAspect>();
            containerBuilder.RegisterType<ChangeArgumentsAspect>();

            return containerBuilder.Build();
        }
    }
}