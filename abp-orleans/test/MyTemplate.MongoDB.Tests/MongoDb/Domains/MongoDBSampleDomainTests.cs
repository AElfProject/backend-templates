using MyTemplate.Samples;
using Xunit;

namespace MyTemplate.MongoDB.Domains;

[Collection(MyTemplateTestConsts.CollectionDefinitionName)]
public class MongoDBSampleDomainTests : SampleDomainTests<MyTemplateMongoDbTestModule>
{

}
