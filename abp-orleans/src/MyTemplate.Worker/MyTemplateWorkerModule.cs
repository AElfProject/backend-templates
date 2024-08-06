using Microsoft.Extensions.DependencyInjection;
using MyTemplate.Application.Grains;
using MyTemplate.Domain.Grains;
using MyTemplate.MongoDB;
using MyTemplate.Worker.Author;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Modularity;

namespace MyTemplate.Worker;

[DependsOn(
    typeof(AbpBackgroundWorkersModule),
    typeof(AbpAspNetCoreMvcModule),
    typeof(MyTemplateApplicationModule),
    typeof(MyTemplateMongoDbModule),
    typeof(AbpAutofacModule)
)]
public class MyTemplateWorkerModule : AbpModule, IDomainGrainsModule, IApplicationGrainsModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();
        context.Services.AddHttpClient();
    }

    public override async Task OnApplicationInitializationAsync(ApplicationInitializationContext context)
    {
        // add your background workers here
        await context.AddBackgroundWorkerAsync<AuthorSummaryWorker>();
    }
}