using DomainDrivenDesign.DomainObjects.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.Interfaces;

public interface IPhoneNumberFormatter
{
    string Format(PhoneNumber number);
}
