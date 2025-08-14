using DomainDrivenDesign.Abstractions.Attributes;
using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.ValueObjects;

[StringValidation(MinLength = MIN_LENGTH, MaxLength = MAX_LENGTH)]
public record AddressPart : ValidatableStringValue
{
    public const int MIN_LENGTH = 2;
    public const int MAX_LENGTH = 80;
    public AddressPart(string value) : base(value)
    {
    }
}
