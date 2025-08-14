using DomainDrivenDesign.Abstractions.Attributes;
using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.ValueObjects;

[StringValidation(Pattern = "^[0-9]+$")]
public record Integer : ValidatableStringValue
{
    public Integer(string value) : base(value)
    {
    }
}
