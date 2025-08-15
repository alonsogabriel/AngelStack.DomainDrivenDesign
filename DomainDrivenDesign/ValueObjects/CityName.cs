using AngelStack.DomainDrivenDesign.Abstractions;

namespace DomainDrivenDesign.ValueObjects;

// [StringValidation(MinLength = MIN_LENGTH)]

public record CityName : StringValueValidatable
{
    public const int MIN_LENGTH = 2;
    public const int MAX_LENGTH = 100;

    public CityName(string value) : base(value) { }
}