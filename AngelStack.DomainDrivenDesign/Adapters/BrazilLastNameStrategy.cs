using AngelStack.Common.Guards;
using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Interfaces;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Adapters;

public class BrazilLastNameStrategy : ILastNameStrategy
{
    private static readonly string[] _invalid = ["JUNIOR", "FILHO", "NETO", "JR.", "JR"];
    public string GetLastName(PersonName name)
    {
        var parts = name.Guard().Value.Split(' ');

        if (parts.Length < 2) return string.Empty;

        var last = parts.Last().RemoveDiacritics().ToUpper();

        if (_invalid.Contains(last) || RegularExpressions.RomanNumerals().IsMatch(last))
        {
            return parts.Length > 2 ? parts[^2] : string.Empty;
        }

        return parts.Last();
    }
}