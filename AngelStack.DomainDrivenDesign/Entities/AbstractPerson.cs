using AngelStack.Common.Guards;
using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Entities;

public enum Gender
{
    Male,
    Female,
}

public class AbstractPerson : AbstractEntity
{
    protected AbstractPerson() { }

    public AbstractPerson(PersonName name, DateOfBirth? dateOfBirth, Gender? gender, City? placeOfBirth)
    {
        Name = name.Guard();
        DateOfBirth = dateOfBirth;
        Gender = gender;
        PlaceOfBirth = placeOfBirth;
    }

    public PersonName Name { get; protected set; }
    public DateOfBirth? DateOfBirth { get; protected set; }
    public Gender? Gender { get; protected set; }
    public City? PlaceOfBirth { get; protected set; }
}