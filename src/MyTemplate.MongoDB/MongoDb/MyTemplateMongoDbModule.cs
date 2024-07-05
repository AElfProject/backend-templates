using Microsoft.Extensions.DependencyInjection;
using MyTemplate.Books;
using Volo.Abp.AuditLogging.MongoDB;
using Volo.Abp.BackgroundJobs.MongoDB;
using Volo.Abp.Identity.MongoDB;
using Volo.Abp.Modularity;
using Volo.Abp.OpenIddict.MongoDB;
using Volo.Abp.PermissionManagement.MongoDB;
using Volo.Abp.Uow;

namespace MyTemplate.MongoDB;

[DependsOn(
    typeof(MyTemplateDomainModule),
    typeof(AbpPermissionManagementMongoDbModule),
    typeof(AbpIdentityMongoDbModule),
    typeof(AbpOpenIddictMongoDbModule),
    typeof(AbpBackgroundJobsMongoDbModule),
    typeof(AbpAuditLoggingMongoDbModule)
    )]
public class MyTemplateMongoDbModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        //Example only, remove if not needed
        context.Services.AddMongoDbContext<BookStoreMongoDbContext>(options =>
        {
            options.AddDefaultRepositories();
        });
        
        context.Services.AddMongoDbContext<MyTemplateMongoDbContext>(options =>
        {
            options.AddDefaultRepositories();
        });

        Configure<AbpUnitOfWorkDefaultOptions>(options =>
        {
            options.TransactionBehavior = UnitOfWorkTransactionBehavior.Disabled;
        });
    }
}
