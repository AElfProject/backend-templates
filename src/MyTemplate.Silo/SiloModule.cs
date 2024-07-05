using MyTemplate.Domain.Grains;
using Microsoft.Extensions.DependencyInjection;
using MyTemplate.Application.Grains;
using Volo.Abp.AspNetCore.Serilog;
using Volo.Abp.Autofac;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
namespace MyTemplate.Silo;

[DependsOn(
    typeof(AbpAspNetCoreSerilogModule),
    typeof(AbpAutofacModule)
)]
public class SiloModule : AbpModule, IDomainGrainsModule, IApplicationGrainsModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options => { options.AddMaps<SiloModule>(); });
        context.Services.AddHostedService<MyTemplateHostedService>();
        var configuration = context.Services.GetConfiguration();
        //add dependencies here

        context.Services.AddHttpClient();
    }
}