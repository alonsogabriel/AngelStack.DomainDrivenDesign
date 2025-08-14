using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.ValueObjects;

public record CountryCode : ValidatableStringValue
{
    public CountryCode(string value) : base(value)
    {
    }
}
