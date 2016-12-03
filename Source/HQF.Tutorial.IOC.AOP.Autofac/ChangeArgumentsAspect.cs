using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using HQF.Tutorial.IOC.Common.Models;

namespace HQF.Tutorial.IOC.AOP.Autofac
{
    public class ChangeArgumentsAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var arguments = invocation.Arguments;

            foreach (var argument in arguments)
            {
                ItemEntity itemEntity;

                if ((itemEntity = argument as ItemEntity) != null)
                    itemEntity.Name += "| Name changed by interceptor";
            }

            invocation.Proceed();

            var result = invocation.ReturnValue as ItemEntity;

            if (result != null) result.Quiantity = 420;
        }
    }
}
