using DomainDrivenDesign.Abstractions.Attributes;
using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.ValueObjects;

[StringValidation(MinLength = 1, MaxLength = 20)]
public record RegionAlias : ValidatableStringValue
{
    public RegionAlias(string value) : base(value) { }
}