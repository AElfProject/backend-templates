using Volo.Abp.Modularity;

namespace MyTemplate;

public abstract class MyTemplateApplicationTestBase<TStartupModule> : MyTemplateTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
