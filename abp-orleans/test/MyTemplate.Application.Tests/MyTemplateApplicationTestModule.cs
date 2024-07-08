using Volo.Abp.Modularity;

namespace MyTemplate;

[DependsOn(
    typeof(MyTemplateApplicationModule),
    typeof(MyTemplateDomainTestModule)
)]
public class MyTemplateApplicationTestModule : AbpModule
{

}
