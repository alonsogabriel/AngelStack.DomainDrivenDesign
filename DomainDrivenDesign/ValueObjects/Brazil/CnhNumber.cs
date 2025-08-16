using AngelStack.DomainDrivenDesign.Abstractions;

namespace DomainDrivenDesign.ValueObjects.Brazil;

// [StringValidation(Pattern = "^[0-9]{9}$")]
public record CnhNumber : StringValidatable
{
    public const int MAX_LENGTH = 9;
    public CnhNumber(string value) : base(value)
    {
    }
}
