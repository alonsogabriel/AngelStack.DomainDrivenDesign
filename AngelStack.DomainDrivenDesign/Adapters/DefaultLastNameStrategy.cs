using AngelStack.Common.Guards;
using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Interfaces;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Adapters;

public class DefaultLastNameStrategy : ILastNameStrategy
{
    public string GetLastName(PersonName name)
    {
        var parts = name.Guard().Value.Split(' ');

        if (parts.Length < 2) return string.Empty;

        var last = parts.Last().RemoveDiacritics().ToUpper();

        if (RegularExpressions.RomanNumerals().IsMatch(last))
        {
            return parts.Length > 2 ? parts[^2] : string.Empty;
        }

        return parts.Last();
    }
}
