using AngelStack.DomainDrivenDesign.Abstractions;

namespace DomainDrivenDesign.ValueObjects;

// [StringValidation(MinLength = MIN_LENGTH, MaxLength = MAX_LENGTH)]
public record RegionAlias : StringValueValidatable
{
    public const int MIN_LENGTH = 1;
    public const int MAX_LENGTH = 20;
    public RegionAlias(string value) : base(value) { }
}