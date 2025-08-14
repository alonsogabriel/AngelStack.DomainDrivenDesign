using DomainDrivenDesign.DomainObjects.Interfaces;
using DomainDrivenDesign.DomainObjects.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.Adapters;

public class BrazilPhoneNumberFormatter : IPhoneNumberFormatter
{
    public string Format(PhoneNumber number)
    {
        if (number.Number.Length is not (8 or 9))
        {
            throw new InvalidOperationException("Brazilian phone numbers must have 8 or 9 digits.");
        }

        var countryCode = number.CountryCode.Value;
        var areaCode = number.AreaCode!.Value;
        var splitIndex = number.Number.Length == 9 ? 5 : 4;
        var start = number.Number.Value[..splitIndex];
        var end = number.Number.Value[splitIndex..];

        return $"+{countryCode} ({areaCode}) {start}-{end}";
    }
}
