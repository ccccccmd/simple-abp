﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.DependencyInjection;

namespace Simple.Abp.Test
{
    public interface ITestAppService : IRemoteService, IScopedDependency
    {
        string Get();
    }
}
