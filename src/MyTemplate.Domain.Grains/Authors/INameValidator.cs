namespace MyTemplate.Domain.Grains.Authors;

public interface INameValidator : IGrainWithGuidKey
{
    Task<bool> IsValid(string name);
}