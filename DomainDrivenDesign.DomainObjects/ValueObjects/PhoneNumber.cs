using DomainDrivenDesign.Abstractions.Extensions;

namespace DomainDrivenDesign.DomainObjects.ValueObjects;

public enum PhoneNumberFormat
{
    Brazil,
    Usa,
}

public record PhoneNumber
{
    public PhoneNumber(CountryCode countryCode, AreaCode? areaCode, Integer number)
    {
        CountryCode = countryCode.Guard(new ArgumentNullException(nameof(countryCode)));
        AreaCode = areaCode;
        Number = number.Guard(new ArgumentNullException(nameof(number)));
    }

    public CountryCode CountryCode { get; protected set; }
    public AreaCode? AreaCode { get; protected set; }
    public Integer Number { get; protected set; }

    public string Value => $"+{CountryCode} {AreaCode}{Number}";

    public string Format(PhoneNumberFormat format)
    {
        return format switch
        {
            PhoneNumberFormat.Brazil => Value,
            PhoneNumberFormat.Usa => Value,
            _ => Value,
        };
    }
}