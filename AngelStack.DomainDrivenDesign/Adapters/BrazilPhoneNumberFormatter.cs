using AngelStack.DomainDrivenDesign.Constants;
using AngelStack.DomainDrivenDesign.Interfaces;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Adapters;

public class BrazilPhoneNumberFormatter : IPhoneNumberFormatter
{
    public string Format(PhoneNumber number)
    {
        var fromBrazil = number.CountryCode.Value is CountryCodes.Brazil;
        var validLength = number.Length is 10 or 11;

        if (!fromBrazil || !validLength) return number.Value;

        var countryCode = number.CountryCode.Value;
        var splitIndex = number.Length - 4;
        var areaCode = number.Value[..2];
        var start = number.Value[2..splitIndex];
        var end = number.Value[splitIndex..];

        return $"+{countryCode} ({areaCode}) {start}-{end}";
    }
}
