﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQF.Tutorial.IOC.Autofac.Generic
{
    public interface IEventHander<T> where T:IEvent
    {
    }
}
