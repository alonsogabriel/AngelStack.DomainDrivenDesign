using AngelStack.DomainDrivenDesign.Abstractions;

namespace DomainDrivenDesign.ValueObjects;

// [StringValidation(MaxLength = MAX_LENGTH, Pattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$")]
public record Email : StringValueValidatable
{
    public const int MAX_LENGTH = 150;
    public Email(string value) : base(value)
    {
    }
}