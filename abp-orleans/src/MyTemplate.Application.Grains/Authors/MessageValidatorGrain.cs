using Microsoft.Extensions.Logging;

namespace MyTemplate.Application.Grains.Authors;

public class MessageValidatorGrain : Grain, IMessageValidator
{
    private readonly ILogger _logger;
    private static readonly string[] OffensiveWords = new string[] {"offensive", "bad", "rude"};

    public MessageValidatorGrain(ILogger<MessageValidatorGrain> logger)
    {
        _logger = logger;
    }

    public Task<bool> IsOffensive(string message)
    {
        _logger.LogInformation("""
                               IsOffensive message received: message = "{Message}"
                               """,
            message);
        
        return Task.FromResult(OffensiveWords.Any(message.Contains));
    }
}