using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.ValueObjects;

public record AreaCode : ValidatableStringValue
{
    public AreaCode(string value) : base(value)
    {
    }
}
