using AngelStack.Common.Guards;
using AngelStack.DomainDrivenDesign.Constants;
using AngelStack.DomainDrivenDesign.Interfaces;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Adapters;

internal class UsPhoneNumberFormatter : IPhoneNumberFormatter
{
    public string Format(PhoneNumber number)
    {
        var fromUs = number.CountryCode.Value is CountryCodes.UnitedStates;

        if (!fromUs) return number.Value;

        var countryCode = number.CountryCode.Value;
        int splitIndex = number.Value.Length - 4;
        var areaCode = number.Value[..3];
        var start = number.Value[3..splitIndex];
        var end = number.Value[splitIndex..];

        return $"+{countryCode} ({areaCode}) {start}-{end}";
    }
}
