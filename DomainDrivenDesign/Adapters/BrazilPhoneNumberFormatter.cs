using AngelStack.Common.Guards;
using AngelStack.DomainDrivenDesign.Constants;
using AngelStack.DomainDrivenDesign.Interfaces;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Adapters;

public class BrazilPhoneNumberFormatter : IPhoneNumberFormatter
{
    public string Format(PhoneNumber number)
    {
        if (number.CountryCode.Value is not CountryCodes.Brazil)
        {
            throw new ArgumentException("Invalid country code.", nameof(number.CountryCode));
        }
        if (number.Number.Length is not (8 or 9))
        {
            throw new InvalidOperationException("Brazilian phone numbers must have 8 or 9 digits.");
        }

        number.AreaCode.Guard();

        var countryCode = number.CountryCode.Value;
        var areaCode = number.AreaCode!.Value;
        var splitIndex = number.Number.Length - 4;
        var start = number.Number.Value[..splitIndex];
        var end = number.Number.Value[splitIndex..];

        return $"+{countryCode} ({areaCode}) {start}-{end}";
    }
}
