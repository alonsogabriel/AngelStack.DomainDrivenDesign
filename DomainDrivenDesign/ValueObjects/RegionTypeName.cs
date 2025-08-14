using DomainDrivenDesign.Abstractions.Attributes;
using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.ValueObjects;

[StringValidation(MinLength = MIN_LENGTH, MaxLength = MAX_LENGTH)]
public record RegionTypeName : ValidatableStringValue
{
    public const int MIN_LENGTH = 2;
    public const int MAX_LENGTH = 80;
    public RegionTypeName(string value) : base(value) { }
}