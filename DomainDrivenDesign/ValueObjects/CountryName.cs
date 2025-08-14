using DomainDrivenDesign.Abstractions.Attributes;
using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.ValueObjects;

[StringValidation(MinLength = MIN_LENGTH)]
public record CountryName : ValidatableStringValue
{
    public const int MIN_LENGTH = 2;
    public const int MAX_LENGTH = 100;
    public CountryName(string value) : base(value)
    {
    }
}
