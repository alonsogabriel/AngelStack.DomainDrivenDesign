using AngelStack.DomainDrivenDesign.Interfaces;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Adapters;

public class DefaultPhoneNumberFormatter : IPhoneNumberFormatter
{
    public string Format(PhoneNumber number)
    {
        var areaCode = number.AreaCode is not null ?
            $"({number.AreaCode.Value}) " : string.Empty;

        return $"+{number.CountryCode.Value} {areaCode}{number.Value}";
    }
}
