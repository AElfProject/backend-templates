using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MyTemplate;

[Dependency(ReplaceServices = true)]
public class MyTemplateBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MyTemplate";
}
