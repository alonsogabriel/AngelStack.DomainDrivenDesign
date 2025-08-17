using System.Text.RegularExpressions;

namespace AngelStack.DomainDrivenDesign;

public static partial class RegularExpressions
{
    [GeneratedRegex("^(?<numeral>(?<thousands>M{0,3})(?<hundreds>CM|CD|D?C{0,3})(?<tens>XC|XL|L?X{0,3})(?<units>IX|IV|V?I{0,3}))$", RegexOptions.Compiled)]
    public static partial Regex RomanNumerals();

    [GeneratedRegex("^[0-9]{11}$", RegexOptions.Compiled | RegexOptions.Singleline)]
    public static partial Regex CpfRegex();
}
