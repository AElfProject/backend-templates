using MyTemplate.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyTemplate.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MyTemplateController : AbpControllerBase
{
    protected MyTemplateController()
    {
        LocalizationResource = typeof(MyTemplateResource);
    }
}
