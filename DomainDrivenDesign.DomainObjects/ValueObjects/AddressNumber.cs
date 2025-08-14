using DomainDrivenDesign.Abstractions.Attributes;
using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.ValueObjects;

[StringValidation(MinLength = MIN_LENGTH, MaxLength = MAX_LENGTH, Pattern = "^[A-Za-z0-9\\-]+$")]
public record AddressNumber : ValidatableStringValue
{
    public const int MIN_LENGTH = 1;
    public const int MAX_LENGTH = 20;
    public AddressNumber(string value) : base(value) { }
}
