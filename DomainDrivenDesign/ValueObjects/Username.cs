using AngelStack.DomainDrivenDesign.Abstractions;

namespace DomainDrivenDesign.ValueObjects;

// [StringValidation(Pattern = "^[A-Za-z0-9_\\-]{2,32}$")]
public record Username : StringValueValidatable
{
    public const int MAX_LENGTH = 32;
    public Username(string value) : base(value)
    {
    }
}
