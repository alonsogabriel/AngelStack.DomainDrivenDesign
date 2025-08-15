using AngelStack.Common.Guards;
using DomainDrivenDesign.Adapters;
using DomainDrivenDesign.Constants;
using DomainDrivenDesign.Interfaces;
using DomainDrivenDesign.ValueObjects;

namespace DomainDrivenDesign.Factories;

public static class PhoneNumberFormatterFactory
{
    public static IPhoneNumberFormatter FromCountryCode(CountryCode code)
    {
        code.Guard();

        return code.Value switch
        {
            CountryCodes.Brazil => new BrazilPhoneNumberFormatter(),
            CountryCodes.UnitedStates => new UsPhoneNumberFormatter(),
            _ => new DefaultPhoneNumberFormatter(),
        };
    }
}
