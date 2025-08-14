using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.ValueObjects;

public record AreaCode : ValidatableStringValue
{
    public AreaCode(string value) : base(value)
    {
    }
}
