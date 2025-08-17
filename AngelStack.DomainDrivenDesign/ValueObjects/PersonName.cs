using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.DomainDrivenDesign.Adapters;
using AngelStack.DomainDrivenDesign.Interfaces;

namespace AngelStack.DomainDrivenDesign.ValueObjects;

[Required]
[MinLength(2)]
[MaxLength(120)]
public record PersonName(string Value) : StringValidatable(Value)
{
    public string GetFirstName()
    {
        return Value.Split(' ').FirstOrDefault() ?? string.Empty;
    }

    public string GetLastName(ILastNameStrategy? strategy = null)
    {
        strategy ??= new DefaultLastNameStrategy();

        return strategy.GetLastName(this);
    }

    public string GetInitials()
    {
        var parts = Value.ToUpper().Split(' ');
        var first = parts.FirstOrDefault()?.FirstOrDefault() ?? '?';
        var last = parts.LastOrDefault()?.FirstOrDefault() ?? '?';

        return string.Concat(first, last);
    }
}