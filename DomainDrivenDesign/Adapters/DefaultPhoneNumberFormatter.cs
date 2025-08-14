using DomainDrivenDesign.Interfaces;
using DomainDrivenDesign.ValueObjects;

namespace DomainDrivenDesign.Adapters;

public class DefaultPhoneNumberFormatter : IPhoneNumberFormatter
{
    public string Format(PhoneNumber number)
    {
        return number.Value;
    }
}
