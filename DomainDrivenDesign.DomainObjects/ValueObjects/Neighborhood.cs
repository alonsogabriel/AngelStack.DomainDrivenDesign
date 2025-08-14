using DomainDrivenDesign.Abstractions.Attributes;
using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.ValueObjects;

[StringValidation(MinLength = MIN_LENGTH, MaxLength = MAX_LENGTH)]
public record Neighborhood : ValidatableStringValue
{
    public const int MIN_LENGTH = 1;
    public const int MAX_LENGTH = 80;
    public Neighborhood(string value) : base(value) { }
}