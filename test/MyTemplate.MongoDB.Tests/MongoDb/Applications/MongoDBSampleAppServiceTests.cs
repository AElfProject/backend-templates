using MyTemplate.MongoDB;
using MyTemplate.Samples;
using Xunit;

namespace MyTemplate.MongoDb.Applications;

[Collection(MyTemplateTestConsts.CollectionDefinitionName)]
public class MongoDBSampleAppServiceTests : SampleAppServiceTests<MyTemplateMongoDbTestModule>
{

}
