﻿using System;
using Simple.Abp.IdentityServer.ApiResources.Dtos;
using Simple.Abp.IdentityServer.Clients.Dtos;
using Simple.Abp.IdentityServer.IdentityResources.Dtos;
using Volo.Abp.IdentityServer;
using Volo.Abp.IdentityServer.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Simple.Abp.IdentityServer
{
    [DependsOn(
		typeof(AbpIdentityServerDomainSharedModule)
	)]
	public class AbpIdentityServerApplicationContractsModule : AbpModule
	{
		public override void ConfigureServices(ServiceConfigurationContext context)
		{
			Configure<AbpVirtualFileSystemOptions>(options =>
			{
				options.FileSets.AddEmbedded<AbpIdentityServerApplicationContractsModule>();
			});
			Configure<AbpLocalizationOptions>(options =>
			{
				options.Resources.Get<AbpIdentityServerResource>().AddVirtualJson("Volo/Abp/IdentityServer/Localization/Resources/IdentityServer/ApplicationContracts");
			});
		}

		public override void PostConfigureServices(ServiceConfigurationContext context)
		{
			ModuleExtensionConfigurationHelper.ApplyEntityConfigurationToApi("IdentityServer", "Client", new Type[]
			{
				typeof(ClientWithDetailsDto)
			}, new Type[]
			{
				typeof(CreateClientDto)
			}, new Type[]
			{
				typeof(UpdateClientDto)
			});
			ModuleExtensionConfigurationHelper.ApplyEntityConfigurationToApi("IdentityServer", "IdentityResource", new Type[]
			{
				typeof(IdentityResourceWithDetailsDto)
			}, new Type[]
			{
				typeof(CreateIdentityResourceDto)
			}, new Type[]
			{
				typeof(UpdateIdentityResourceDto)
			});
			ModuleExtensionConfigurationHelper.ApplyEntityConfigurationToApi("IdentityServer", "ApiResource", new Type[]
			{
				typeof(ApiResourceWithDetailsDto)
			}, new Type[]
			{
				typeof(CreateApiResourceDto)
			}, new Type[]
			{
				typeof(UpdateApiResourceDto)
			});
		}
	}
}
