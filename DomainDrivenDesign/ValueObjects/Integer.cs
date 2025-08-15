using AngelStack.DomainDrivenDesign.Abstractions;

namespace DomainDrivenDesign.ValueObjects;

// [StringValidation(Pattern = "^[0-9]+$")]
public record Integer : StringValueValidatable
{
    public Integer(string value) : base(value)
    {
    }
}
