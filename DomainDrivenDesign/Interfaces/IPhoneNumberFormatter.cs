using DomainDrivenDesign.ValueObjects;

namespace DomainDrivenDesign.Interfaces;

public interface IPhoneNumberFormatter
{
    string Format(PhoneNumber number);
}
