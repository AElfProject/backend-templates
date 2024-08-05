﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyTemplate.Worker.Extensions;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.OpenTelemetry;

namespace MyTemplate.Worker
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            ConfigureLogger();
            
            try
            {
                Log.Information("Starting Worker.");
                var builder = WebApplication.CreateBuilder(args);
                builder.Host
                    .AddAppSettingsSecretsJson()
                    .UseOrleansClientConfiguration()
                    .ConfigureDefaults(args)
                    .UseAutofac()
                    .UseSerilog();
                await builder.AddApplicationAsync<MyTemplateWorkerModule>();
                var app = builder.Build();
                await app.InitializeApplicationAsync();
                await app.RunAsync();
                await CreateHostBuilder(args).RunConsoleAsync();
                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly!");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        private static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(build => { build.AddJsonFile("appsettings.secrets.json", optional: true); })
            .ConfigureServices((hostContext, services) => { services.AddApplication<MyTemplateWorkerModule>(); })
            .UseAutofac()
            .UseSerilog();
        
        private static void ConfigureLogger(LoggerConfiguration? loggerConfiguration = null)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            Log.Logger = (loggerConfiguration ?? new LoggerConfiguration())
                .ReadFrom.Configuration(configuration)
#if DEBUG
                .WriteTo.OpenTelemetry(
                    endpoint: "http://localhost:4316/v1/logs",
                    protocol: OtlpProtocol.HttpProtobuf)
                .MinimumLevel.Debug()
#else
                .MinimumLevel.Information()
#endif
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                .CreateLogger();
        }
    }
}