using Volo.Abp.Modularity;

namespace MyTemplate;

[DependsOn(
    typeof(MyTemplateDomainModule),
    typeof(MyTemplateTestBaseModule)
)]
public class MyTemplateDomainTestModule : AbpModule
{

}
