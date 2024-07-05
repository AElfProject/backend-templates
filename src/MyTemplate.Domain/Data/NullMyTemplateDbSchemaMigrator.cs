using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MyTemplate.Data;

/* This is used if database provider does't define
 * IMyTemplateDbSchemaMigrator implementation.
 */
public class NullMyTemplateDbSchemaMigrator : IMyTemplateDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
