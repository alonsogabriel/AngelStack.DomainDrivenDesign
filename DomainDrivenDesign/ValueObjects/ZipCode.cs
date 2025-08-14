using DomainDrivenDesign.Abstractions.Attributes;
using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.ValueObjects;

[StringValidation(MinLength = MIN_LENGTH, MaxLength = MAX_LENGTH, Pattern = "^[A-Za-z0-9\\-\\.]+$")]
public record ZipCode : ValidatableStringValue
{
    public const int MIN_LENGTH = 1;
    public const int MAX_LENGTH = 40;
    public ZipCode(string value) : base(value) { }
}