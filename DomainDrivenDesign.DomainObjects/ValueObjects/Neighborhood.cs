using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.ValueObjects;

public record Neighborhood : ValidatableStringValue
{
    public Neighborhood(string value) : base(value) { }
}