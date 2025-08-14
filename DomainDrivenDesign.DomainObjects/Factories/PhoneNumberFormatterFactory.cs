using DomainDrivenDesign.Abstractions.Extensions;
using DomainDrivenDesign.DomainObjects.Adapters;
using DomainDrivenDesign.DomainObjects.Constants;
using DomainDrivenDesign.DomainObjects.Interfaces;
using DomainDrivenDesign.DomainObjects.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.Factories;

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
