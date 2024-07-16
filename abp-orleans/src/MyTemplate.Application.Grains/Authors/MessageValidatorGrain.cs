using System.Diagnostics;
using AElf.OpenTelemetry;
using AElf.OpenTelemetry.ExecutionTime;
using Microsoft.Extensions.Logging;

namespace MyTemplate.Application.Grains.Authors;

[AggregateExecutionTime]
public class MessageValidatorGrain : Grain, IMessageValidator
{
    private readonly ILogger _logger;
    private readonly ActivitySource _activitySource;
    private static readonly string[] OffensiveWords = new string[] {"offensive", "bad", "rude"};

    public MessageValidatorGrain(ILogger<MessageValidatorGrain> logger
        , IInstrumentationProvider instrumentationProvider)
    {
        _logger = logger;
        _activitySource = instrumentationProvider.ActivitySource;
    }

    public Task<bool> IsOffensive(string message)
    {
        using var myActivity = _activitySource.StartActivity($"{nameof(MessageValidatorGrain)}.IsOffensive");
        
        _logger.LogInformation("""
                               IsOffensive message received: message = "{Message}"
                               """,
            message);
        
        return Task.FromResult(OffensiveWords.Any(message.Contains));
    }
}