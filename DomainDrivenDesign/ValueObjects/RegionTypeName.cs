using AngelStack.DomainDrivenDesign.Abstractions;

namespace DomainDrivenDesign.ValueObjects;

// [StringValidation(MinLength = MIN_LENGTH, MaxLength = MAX_LENGTH)]
public record RegionTypeName : StringValueValidatable
{
    public const int MIN_LENGTH = 2;
    public const int MAX_LENGTH = 80;
    public RegionTypeName(string value) : base(value) { }
}