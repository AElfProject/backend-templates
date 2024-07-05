using Volo.Abp.Modularity;

namespace MyTemplate;

/* Inherit from this class for your domain layer tests. */
public abstract class MyTemplateDomainTestBase<TStartupModule> : MyTemplateTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
