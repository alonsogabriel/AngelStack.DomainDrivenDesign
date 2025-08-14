using DomainDrivenDesign.Abstractions.Attributes;
using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.ValueObjects;

[StringValidation]
public record RegionName : ValidatableStringValue
{
    public RegionName(string value) : base(value) { }
}