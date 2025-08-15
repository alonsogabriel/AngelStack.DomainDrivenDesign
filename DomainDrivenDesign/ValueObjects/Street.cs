using AngelStack.DomainDrivenDesign.Abstractions;

namespace DomainDrivenDesign.ValueObjects;

// [StringValidation(MinLength = MIN_LENGTH, MaxLength = MAX_LENGTH)]
public record Street : StringValueValidatable
{
    public const int MIN_LENGTH = 8;
    public const int MAX_LENGTH = 120;
    public Street(string value) : base(value) { }
}
