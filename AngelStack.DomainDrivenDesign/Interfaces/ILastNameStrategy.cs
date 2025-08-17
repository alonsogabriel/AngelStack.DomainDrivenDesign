using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Interfaces;

public interface ILastNameStrategy
{
    public string GetLastName(PersonName name);
}