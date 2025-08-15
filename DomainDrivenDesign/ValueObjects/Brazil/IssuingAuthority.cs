using AngelStack.DomainDrivenDesign.Abstractions;

namespace DomainDrivenDesign.ValueObjects.Brazil;

// [StringValidation(MinLength = MIN_LENGTH, MaxLength = MAX_LENGTH)]
public record IssuingAuthority : StringValueValidatable
{
    public const int MIN_LENGTH = 1;
    public const int MAX_LENGTH = 20;
    public IssuingAuthority(string value) : base(value)
    {
    }
}
