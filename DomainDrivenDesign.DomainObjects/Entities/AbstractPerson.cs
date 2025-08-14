using DomainDrivenDesign.Abstractions.Entities;
using DomainDrivenDesign.Abstractions.Extensions;
using DomainDrivenDesign.DomainObjects.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.Entities;

public enum Gender
{
    Male,
    Female,
}

public class AbstractPerson : AbstractEntity
{
    protected AbstractPerson() { }

    public AbstractPerson(PersonName name, DateOfBirth? dateOfBirth, Gender? gender)
    {
        Name = name.Guard(new ArgumentNullException(nameof(name)));
        DateOfBirth = dateOfBirth;
        Gender = gender;
    }

    public PersonName Name { get; protected set; }
    public DateOfBirth? DateOfBirth { get; protected set; }
    public Gender? Gender { get; protected set; }
}