using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.ValueObjects;

public record AddressDetails : ValidatableStringValue
{
    public AddressDetails(string value) : base(value) { }
}