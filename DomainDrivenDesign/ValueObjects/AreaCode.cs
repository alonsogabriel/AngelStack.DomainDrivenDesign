using AngelStack.DomainDrivenDesign.Abstractions;

namespace DomainDrivenDesign.ValueObjects;

public record AreaCode : StringValueValidatable
{
    public AreaCode(string value) : base(value)
    {
    }
}
