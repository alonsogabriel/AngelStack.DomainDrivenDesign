using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;
using DomainDrivenDesign.Interfaces;

namespace DomainDrivenDesign.ValueObjects;

[Required]
[MinLength(2)]
[MaxLength(120)]
public record PersonName(string Value) : StringValueValidatable(Value)
{
    public string GetFirstName()
    {
        return Value.Split(' ').FirstOrDefault() ?? string.Empty;
    }

    public string GetLastName(ILastNameStrategy? strategy = null)
    {
        return strategy?.GetLastName(this) ??
            Value.Split(' ').LastOrDefault() ??
            string.Empty;
    }

    public string GetInitials()
    {
        var parts = Value.ToUpper().Split(' ');
        var first = parts.FirstOrDefault()?.FirstOrDefault() ?? '?';
        var last = parts.LastOrDefault()?.FirstOrDefault() ?? '?';

        return string.Concat(first, last);
    }
}