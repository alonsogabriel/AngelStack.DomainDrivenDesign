using AngelStack.Common.Guards;
using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Interfaces;

public interface ILastNameStrategy
{
    public string GetLastName(PersonName name);
}

public class BrazilLastNameStrategy : ILastNameStrategy
{
    public string GetLastName(PersonName name)
    {
        var parts = name.Guard().Value.Split(' ');
        var last = parts.Last().RemoveDiacritics().ToUpper();
        string[] invalid = ["JUNIOR", "FILHO", "NETO"];

        if (invalid.Contains(last))
        {
            return parts.Length > 2 ? parts[^2] : string.Empty;
        }

        return parts.Last();
    }
}