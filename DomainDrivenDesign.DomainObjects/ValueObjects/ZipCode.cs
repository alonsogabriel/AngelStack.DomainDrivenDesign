using DomainDrivenDesign.Abstractions.Attributes;
using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.ValueObjects;

[StringValidation(Pattern = "^[A-Za-z0-9\\-\\.]+$")]
public record ZipCode : ValidatableStringValue
{
    public ZipCode(string value) : base(value) { }
}