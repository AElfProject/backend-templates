using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace MyTemplate.MongoDB;

[DependsOn(
    typeof(MyTemplateApplicationTestModule),
    typeof(MyTemplateMongoDbModule)
)]
public class MyTemplateMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = MyTemplateMongoDbFixture.GetRandomConnectionString();
        });
    }
}
