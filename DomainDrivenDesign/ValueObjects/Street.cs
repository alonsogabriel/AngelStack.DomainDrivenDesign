using DomainDrivenDesign.Abstractions.Attributes;
using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.ValueObjects;

[StringValidation(MinLength = MIN_LENGTH, MaxLength = MAX_LENGTH)]
public record Street : ValidatableStringValue
{
    public const int MIN_LENGTH = 8;
    public const int MAX_LENGTH = 120;
    public Street(string value) : base(value) { }
}
