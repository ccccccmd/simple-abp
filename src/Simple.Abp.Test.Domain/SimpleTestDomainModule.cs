﻿using Volo.Abp.AuditLogging;
using Volo.Abp.Identity;
using Volo.Abp.IdentityServer;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.Identity;
using Volo.Abp.PermissionManagement.IdentityServer;
using Volo.Abp.SettingManagement;

namespace Simple.Abp.Test
{
    [DependsOn(
        typeof(SimpleTestDomainSharedModule),
        typeof(AbpIdentityDomainModule),
        typeof(AbpIdentityServerDomainModule),
        typeof(AbpPermissionManagementDomainIdentityModule),
        typeof(AbpPermissionManagementDomainIdentityServerModule),
        typeof(AbpSettingManagementDomainModule),
        typeof(AbpAuditLoggingDomainModule)
        )]
    public class SimpleTestDomainModule: AbpModule
    {
    }
}
