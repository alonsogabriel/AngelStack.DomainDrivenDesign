using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.ValueObjects;

public record Street : ValidatableStringValue
{
    public Street(string value) : base(value) { }
}
