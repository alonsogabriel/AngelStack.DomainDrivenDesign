using DomainDrivenDesign.Abstractions.Attributes;
using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.ValueObjects;

[StringValidation(MinLength = MIN_LENGTH, MaxLength = MAX_LENGTH)]
public record RegionName : ValidatableStringValue
{
    public const int MIN_LENGTH = 1;
    public const int MAX_LENGTH = 80;
    public RegionName(string value) : base(value) { }
}