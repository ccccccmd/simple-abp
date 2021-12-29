﻿using Microsoft.Extensions.DependencyInjection;
using Simple.Abp.AuditLogging;
using Simple.Abp.Identity;
using Simple.Abp.IdentityServer;
using Volo.Abp.Modularity;

namespace Simple.Abp.Test
{
    [DependsOn(
        typeof(SimpleTestApplicationContractsModule),
        typeof(AbpIdentityHttpApiClientModule),
        typeof(AbpIdentityServerHttpApiClientModule),
        typeof(AbpAuditLoggingHttpApiClientModule)
    )]
    public class SimpleTestHttpApiClientModule:AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(SimpleTestApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
