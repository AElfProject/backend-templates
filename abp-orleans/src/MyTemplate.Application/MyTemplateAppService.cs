using System;
using System.Collections.Generic;
using System.Text;
using MyTemplate.Localization;
using Volo.Abp.Application.Services;

namespace MyTemplate;

/* Inherit your application services from this class.
 */
public abstract class MyTemplateAppService : ApplicationService
{
    protected MyTemplateAppService()
    {
        LocalizationResource = typeof(MyTemplateResource);
    }
}
