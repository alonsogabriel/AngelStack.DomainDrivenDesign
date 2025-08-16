using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Interfaces;

public interface IPhoneNumberFormatter
{
    string Format(PhoneNumber number);
}
