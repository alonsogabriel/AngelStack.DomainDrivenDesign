using AngelStack.Common.Guards;
using AngelStack.DomainDrivenDesign.Adapters;
using AngelStack.DomainDrivenDesign.Constants;
using AngelStack.DomainDrivenDesign.Interfaces;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Factories;

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
