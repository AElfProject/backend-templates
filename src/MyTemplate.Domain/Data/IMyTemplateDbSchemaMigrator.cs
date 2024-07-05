using System.Threading.Tasks;

namespace MyTemplate.Data;

public interface IMyTemplateDbSchemaMigrator
{
    Task MigrateAsync();
}
