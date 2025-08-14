using DomainDrivenDesign.Abstractions.Extensions;
using DomainDrivenDesign.Adapters;
using DomainDrivenDesign.Constants;
using DomainDrivenDesign.Interfaces;
using DomainDrivenDesign.ValueObjects;

namespace DomainDrivenDesign.Factories;

public static class PhoneNumberFormatterFactory
{
    public static IPhoneNumberFormatter FromCountryCode(CountryCode code)
    {
        code.Guard(new ArgumentNullException(nameof(code)));

        return code.Value switch
        {
            CountryCodes.Brazil => new BrazilPhoneNumberFormatter(),
            CountryCodes.UnitedStates => new UsPhoneNumberFormatter(),
            _ => new DefaultPhoneNumberFormatter(),
        };
    }
}
