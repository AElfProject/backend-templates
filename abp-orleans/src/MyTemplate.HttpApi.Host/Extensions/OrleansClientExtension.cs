using System.Net;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Orleans;
using Orleans.Configuration;
using Orleans.Hosting;
using Orleans.Providers.MongoDB.Configuration;

namespace MyTemplate.Extensions;

public static class OrleansClientExtension
{
    public static IHostBuilder UseOrleansClientConfiguration(this IHostBuilder hostBuilder)
    {
        return hostBuilder.UseOrleansClient((context, clientBuilder) =>
        {
            var config = context.Configuration;

            clientBuilder
                .AddActivityPropagation()
                .UseMongoDBClient(config["Orleans:MongoDBClient"])
                .UseMongoDBClustering(options =>
                {
                    options.DatabaseName = config["Orleans:DataBase"];
                    options.Strategy = MongoDBMembershipStrategy.SingleDocument;
                })
                .Configure<ClusterOptions>(options =>
                {
                    options.ClusterId = config["Orleans:ClusterId"];
                    options.ServiceId = config["Orleans:ServiceId"];
                });
        });
    }
}