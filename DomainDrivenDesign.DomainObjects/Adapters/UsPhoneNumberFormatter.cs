using DomainDrivenDesign.Abstractions.Extensions;
using DomainDrivenDesign.DomainObjects.Constants;
using DomainDrivenDesign.DomainObjects.Interfaces;
using DomainDrivenDesign.DomainObjects.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.Adapters;

internal class UsPhoneNumberFormatter : IPhoneNumberFormatter
{
    public string Format(PhoneNumber number)
    {
        number.AreaCode.Guard(new ArgumentNullException(nameof(number.AreaCode)));
        if (number.CountryCode.Value is not CountryCodes.UnitedStates)
        {
            throw new ArgumentException("Invalid country code.", nameof(number.CountryCode));
        }

        var countryCode = number.CountryCode.Value; // Should be "1" for US
        var areaCode = number.AreaCode!.Value;

        // In US, numbers are usually split as NXX-NXXXX
        var start = number.Number.Value[..3];
        var end = number.Number.Value[3..];

        return $"+{countryCode} ({areaCode}) {start}-{end}";
    }
}
