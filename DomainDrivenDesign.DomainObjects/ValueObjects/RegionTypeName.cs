using DomainDrivenDesign.Abstractions.Attributes;
using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.ValueObjects;

[StringValidation]
public record RegionTypeName : ValidatableStringValue
{
    public RegionTypeName(string value) : base(value) { }
}