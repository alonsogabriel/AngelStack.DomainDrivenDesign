using AngelStack.Common.Guards;
using AngelStack.Common.Strings;
using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.DomainDrivenDesign.Factories;

namespace AngelStack.DomainDrivenDesign.ValueObjects;

[Required]
[MaxLength(50)]
[RegularExpression("^[0-9]+$")]
public record PhoneNumber : StringValidatable
{
    protected PhoneNumber() { }
    public PhoneNumber(CountryCode countryCode, string number) : base(number)
    {
        CountryCode = countryCode.Guard();
    }

    public CountryCode CountryCode { get; protected set; }

    public string GetFormatted()
    {
        var formatter = PhoneNumberFormatterFactory.FromCountryCode(CountryCode);

        return formatter.Format(this);
    }
}