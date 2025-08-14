using DomainDrivenDesign.DomainObjects.Interfaces;
using DomainDrivenDesign.DomainObjects.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.Adapters;

internal class UsPhoneNumberFormatter : IPhoneNumberFormatter
{
    public string Format(PhoneNumber number)
    {
        var countryCode = number.CountryCode.Value; // Should be "1" for US
        var areaCode = number.AreaCode!.Value;

        // In US, numbers are usually split as NXX-NXXXX
        var start = number.Number.Value[..3];
        var end = number.Number.Value[3..];

        return $"+{countryCode} ({areaCode}) {start}-{end}";
    }
}
