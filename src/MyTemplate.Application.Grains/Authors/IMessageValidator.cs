namespace MyTemplate.Application.Grains.Authors;

public interface IMessageValidator : IGrainWithGuidKey
{
    Task<bool> IsOffensive(string message);
}